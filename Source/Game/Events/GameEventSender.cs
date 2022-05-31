﻿/*
 * Copyright (C) 2012-2020 CypherCore <http://github.com/CypherCore>
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

using Framework.Constants;
using Game.AI;
using Game.Entities;
using Game.Maps;

namespace Game
{
    class GameEvents
    {
        public static void Trigger(uint gameEventId, WorldObject source, WorldObject target)
        {
            Cypher.Assert(source || target, "At least one of [source] or [target] must be provided");

            WorldObject refForMapAndZoneScript = source ?? target;

            ZoneScript zoneScript = refForMapAndZoneScript.GetZoneScript();
            if (zoneScript == null && refForMapAndZoneScript.IsPlayer())
                zoneScript = refForMapAndZoneScript.FindZoneScript();

            if (zoneScript != null)
                zoneScript.ProcessEvent(target, gameEventId, source);

            Map map = refForMapAndZoneScript.GetMap();
            if (target)
            {
                GameObject goTarget = target.ToGameObject();
                if (goTarget != null)
                {
                    GameObjectAI goAI = goTarget.GetAI();
                    if (goAI != null)
                        goAI.EventInform(gameEventId);
                }

                BattlegroundMap bgMap = map.ToBattlegroundMap();
                if (bgMap != null)
                    bgMap.GetBG().ProcessEvent(target, gameEventId, source);
            }

            map.ScriptsStart(ScriptsType.Event, gameEventId, source, target);
        }

    }
}
