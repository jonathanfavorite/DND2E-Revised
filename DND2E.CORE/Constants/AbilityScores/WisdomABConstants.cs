namespace DND2E.CORE.Constants.AbilityScores
{
    using DND2E.CORE.Models.AbilityScores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class WisdomABConstants
    {
        public const string MagicalAttackAdjustment = "Magical Attack Adjustment";
        public const string BonusSpells = "Bonus Spells";
        public const string SpellFailure = "Spell Failure";
        public const string SpellImmunity = "Spell Immunity";

        public static Dictionary<int, List<AbilityAttribute>> AttributesDict = new Dictionary<int, List<AbilityAttribute>>()
        {
            {1, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MagicalAttackAdjustment, -6),
                    new AbilityAttribute(BonusSpells, 0),
                    new AbilityAttribute(SpellFailure, 80),
                    new AbilityAttribute(SpellImmunity, 0)
                }
            },
            {2, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MagicalAttackAdjustment, -4),
                    new AbilityAttribute(BonusSpells, 0),
                    new AbilityAttribute(SpellFailure, 60),
                    new AbilityAttribute(SpellImmunity, 0)
                }
            },

            {3, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MagicalAttackAdjustment, -3),
                    new AbilityAttribute(BonusSpells, 0),
                    new AbilityAttribute(SpellFailure, 50),
                    new AbilityAttribute(SpellImmunity, 0)
                }
            },

            {4, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MagicalAttackAdjustment, -2),
                    new AbilityAttribute(BonusSpells, 0),
                    new AbilityAttribute(SpellFailure, 45),
                    new AbilityAttribute(SpellImmunity, 0)
                }
            },

            {5, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MagicalAttackAdjustment, -1),
                    new AbilityAttribute(BonusSpells, 0),
                    new AbilityAttribute(SpellFailure, 40),
                    new AbilityAttribute(SpellImmunity, 0)
                }
            },

            {6, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MagicalAttackAdjustment, 0),
                    new AbilityAttribute(BonusSpells, 0),
                    new AbilityAttribute(SpellFailure, 35),
                    new AbilityAttribute(SpellImmunity, 0)
                }
            },

            {7, new List<AbilityAttribute>                {
                    new AbilityAttribute(MagicalAttackAdjustment, 0),
                    new AbilityAttribute(BonusSpells, 0),
                    new AbilityAttribute(SpellFailure, 30),
                    new AbilityAttribute(SpellImmunity, 0)
                }
            },

            {8, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MagicalAttackAdjustment, 0),
                    new AbilityAttribute(BonusSpells, 0),
                    new AbilityAttribute(SpellFailure, 25),
                    new AbilityAttribute(SpellImmunity, 0)
                }
            },

            {9, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MagicalAttackAdjustment, 0),
                    new AbilityAttribute(BonusSpells, 0),
                    new AbilityAttribute(SpellFailure, 20),
                    new AbilityAttribute(SpellImmunity, 0)
                }
            }

        };
        
    }
}
