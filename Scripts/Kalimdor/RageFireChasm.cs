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

using Game.Maps;
using Game.Scripting;

namespace Scripts.Kalimdor
{
    [Script]
    public class RageFireChasm : InstanceMapScript
    {
        public RageFireChasm() : base("instance_ragefire_chasm", 389) { }

        public override InstanceScript GetInstanceScript(InstanceMap map)
        {
            return new RagefireChasmInstanceMapScript(map);
        }

        class RagefireChasmInstanceMapScript : InstanceScript
        {
            public RagefireChasmInstanceMapScript(Map map) : base(map) { }
        }
    }
}
