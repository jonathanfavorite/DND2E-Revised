namespace DND2E.CORE.Constants.AbilityScores
{
    using DND2E.CORE.Models.AbilityScores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DexterityABConstants
    {
        public const string ReactionAdjustment = "Reaction Adjustment";
        public const string MissileAttackAdjustment = "Missile Attack Adjustment";
        public const string DefensiveAdjustment = "Defensive Adjustment";

        public static Dictionary<int, List<AbilityAttribute>> AttributesDict = new Dictionary<int, List<AbilityAttribute>>()
        {
            {1, new List<AbilityAttribute>()
                {
                    new AbilityAttribute(ReactionAdjustment, -6),
                    new AbilityAttribute(MissileAttackAdjustment, -6),
                    new AbilityAttribute(DefensiveAdjustment, -5)
                }
            },
            {2, new List<AbilityAttribute>()
                {
                    new AbilityAttribute(ReactionAdjustment, -4),
                    new AbilityAttribute(MissileAttackAdjustment, -4),
                    new AbilityAttribute(DefensiveAdjustment, -4)
                }
            },
            {3, new List<AbilityAttribute>()
                {
                    new AbilityAttribute(ReactionAdjustment, -3),
                    new AbilityAttribute(MissileAttackAdjustment, -3),
                    new AbilityAttribute(DefensiveAdjustment, -3)
                }
            },
            {4, new List<AbilityAttribute>()
                {
                    new AbilityAttribute(ReactionAdjustment, -2),
                    new AbilityAttribute(MissileAttackAdjustment, -2),
                    new AbilityAttribute(DefensiveAdjustment, -2)
                }
            },
            {5, new List<AbilityAttribute>()
                {
                    new AbilityAttribute(ReactionAdjustment, -1),
                    new AbilityAttribute(MissileAttackAdjustment, -1),
                    new AbilityAttribute(DefensiveAdjustment, -1)
                }
            },
            {6, new List<AbilityAttribute>()
                {
                    new AbilityAttribute(ReactionAdjustment, 0),
                    new AbilityAttribute(MissileAttackAdjustment, 0),
                    new AbilityAttribute(DefensiveAdjustment, 0)
                }
            },
            {7, new List<AbilityAttribute>()
                {
                    new AbilityAttribute(ReactionAdjustment, 0),
                    new AbilityAttribute(MissileAttackAdjustment, 0),
                    new AbilityAttribute(DefensiveAdjustment, 0)
                }
            },
            {8, new List<AbilityAttribute>()
                {
                    new AbilityAttribute(ReactionAdjustment, 0),
                    new AbilityAttribute(MissileAttackAdjustment, 0),
                    new AbilityAttribute(DefensiveAdjustment, 0)
                }
            },
            {9, new List<AbilityAttribute>()
                {
                    new AbilityAttribute(ReactionAdjustment, 0),
                    new AbilityAttribute(MissileAttackAdjustment, 0),
                    new AbilityAttribute(DefensiveAdjustment, 0)
                }
            }
        };
        
    }
}
