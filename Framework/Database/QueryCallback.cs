﻿/*
 * Copyright (C) 2012-2017 CypherCore <http://github.com/CypherCore>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Framework.Database
{
    public class QueryCallback
    {
        public QueryCallback(Task<SQLResult> result)
        {
            _result = result;
        }

        public QueryCallback WithCallback(Action<SQLResult> callback)
        {
            return WithChainingCallback((queryCallback, result) => callback(result));
        }

        public QueryCallback WithCallback<T>(Action<T, SQLResult> callback, T obj)
        {
            return WithChainingCallback((queryCallback, result) => callback(obj, result));
        }

        public QueryCallback WithChainingCallback(Action<QueryCallback, SQLResult> callback)
        {
            _callbacks.Add(new QueryCallbackData(callback));
            return this;
        }

        public void SetNextQuery(QueryCallback next)
        {
            _result = next._result;
        }

        public QueryCallbackStatus InvokeIfReady()
        {
            QueryCallbackData callback = _callbacks.First();
            if (_result.IsCompleted)
            {
                Task<SQLResult> f = _result;
                Action<QueryCallback, SQLResult> cb = callback._result;
                _result = null;
                callback.Clear();

                cb(this, f.Result);

                _callbacks.RemoveAt(0);
                bool hasNext = _result != null;
                if (_callbacks.Empty())
                {
                    Contract.Assert(!hasNext);
                    return QueryCallbackStatus.Completed;
                }

                // abort chain
                if (!hasNext)
                    return QueryCallbackStatus.Completed;

                return QueryCallbackStatus.NextStep;
            }

            return QueryCallbackStatus.NotReady;
        }

        Task<SQLResult> _result;
        List<QueryCallbackData> _callbacks = new List<QueryCallbackData>();
    }

    struct QueryCallbackData
    {
        public QueryCallbackData(Action<QueryCallback, SQLResult> callback)
        {
            _result = callback;
        }

        public void Clear()
        {
            _result = null;
        }

        public Action<QueryCallback, SQLResult> _result;
    }

    public enum QueryCallbackStatus
    {
        NotReady,
        NextStep,
        Completed
    }
}
