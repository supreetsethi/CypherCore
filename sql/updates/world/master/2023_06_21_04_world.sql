DELETE FROM `spell_proc` WHERE `SpellId` IN (26467,36488,38332,39440,40971,45059,60517,67726,67736,67740,67744,71571,71573,75490,75495,85556,90158,90855,91339,91811,92086,92090,92105,96963,96981,97132,97143,333097);
INSERT INTO `spell_proc` (`SpellId`,`SchoolMask`,`SpellFamilyName`,`SpellFamilyMask0`,`SpellFamilyMask1`,`SpellFamilyMask2`,`SpellFamilyMask3`,`ProcFlags`,`ProcFlags2`,`SpellTypeMask`,`SpellPhaseMask`,`HitMask`,`AttributesMask`,`DisableEffectsMask`,`ProcsPerMinute`,`Chance`,`Cooldown`,`Charges`) VALUES
(26467,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Persistent Shield
(36488,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Infernal Protection
(38332,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Blessing of Life
(39440,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Aura of the Crusade
(40971,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Bonus Healing
(45059,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Vessel of the Naaru
(60517,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Talisman of Troll Divinity
(67726,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Escalating Power
(67736,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Volatile Power
(67740,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Escalating Power
(67744,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Volatile Power
(71571,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Item - Icecrown 10 Normal Caster Trinket
(71573,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Item - Icecrown 10 Heroic Caster Trinket
(75490,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Eyes of Twilight
(75495,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Eyes of Twilight
(85556,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Twilight Shift
(90158,0x00,7,0x00000060,0x00000002,0x00000000,0x00000000,0x0,0x0,0x2,0x2,0x403,0x0,0x0,0,0,0,0), -- Item - Druid T11 Restoration 4P Bonus
(90855,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x3,0x2,0x403,0x0,0x0,0,0,0,0), -- Item - Stacking Spell Power
(91339,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Item - Proc Stacking Strength
(91811,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Item - Proc Stacking Strength
(92086,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Item - Proc Stacking Agility
(92090,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Grace
(92105,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Item - Proc Stacking Agility
(96963,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Necromantic Focus
(96981,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x402,0x0,0x0,0,0,0,0), -- Vessel of Acceleration
(97132,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x403,0x0,0x0,0,0,0,0), -- Necromantic Focus
(97143,0x00,0,0x00000000,0x00000000,0x00000000,0x00000000,0x0,0x0,0x1,0x2,0x402,0x0,0x0,0,0,0,0), -- Vessel of Acceleration
(333097,0x00,3,0x00400004,0x00000000,0x00000000,0x00000008,0x0,0x0,0x4,0x2,0x403,0x0,0x0,0,0,0,0); -- Firestorm
