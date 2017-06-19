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

using System.Runtime.Serialization;

namespace Framework.Rest
{
    [DataContract]
    public class ClientVersion
    {
        [DataMember(Name = "versionMajor")]
        public int Major { get; set; }

        [DataMember(Name = "versionBuild")]
        public int Build { get; set; }

        [DataMember(Name = "versionMinor")]
        public int Minor { get; set; }

        [DataMember(Name = "versionRevision")]
        public int Revision { get; set; }
    }
}
