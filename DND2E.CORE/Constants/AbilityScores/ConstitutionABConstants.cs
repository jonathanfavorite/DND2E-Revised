namespace DND2E.CORE.Constants.AbilityScores
{
    using DND2E.CORE.Models.AbilityScores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ConstitutionABConstants
    {
        public const string HitPointAdjustment = "Hit Point Adjustment";
        public const string SystemShockSurvival = "System Shock Survival";
        public const string ResurrectionSurvival = "Resurrection Survival";
        public const string PoisonSave = "Poison Save";
        public const string Regeneration = "Regeneration";

        public static Dictionary<int, List<AbilityAttribute>> AttributesDict = new Dictionary<int, List<AbilityAttribute>>()
        {
            {1, new List<AbilityAttribute>
                {
                    new AbilityAttribute(HitPointAdjustment, -3),
                    new AbilityAttribute(SystemShockSurvival, 25),
                    new AbilityAttribute(ResurrectionSurvival, 30),
                    new AbilityAttribute(PoisonSave, -2),
                    new AbilityAttribute(Regeneration, 0)
                }
            },
            {2, new List<AbilityAttribute>
                {
                    new AbilityAttribute(HitPointAdjustment, -2),
                    new AbilityAttribute(SystemShockSurvival, 30),
                    new AbilityAttribute(ResurrectionSurvival, 35),
                    new AbilityAttribute(PoisonSave, -1),
                    new AbilityAttribute(Regeneration, 0)
                }
            },
            {3, new List<AbilityAttribute>
                {
                    new AbilityAttribute(HitPointAdjustment, -2),
                    new AbilityAttribute(SystemShockSurvival, 35),
                    new AbilityAttribute(ResurrectionSurvival, 40),
                    new AbilityAttribute(PoisonSave, 0),
                    new AbilityAttribute(Regeneration, 0)
                }
            },
            {4, new List<AbilityAttribute>
                {
                    new AbilityAttribute(HitPointAdjustment, -1),
                    new AbilityAttribute(SystemShockSurvival, 40),
                    new AbilityAttribute(ResurrectionSurvival, 45),
                    new AbilityAttribute(PoisonSave, 0),
                    new AbilityAttribute(Regeneration, 0)
                }
            },
            {5, new List<AbilityAttribute>
                {
                    new AbilityAttribute(HitPointAdjustment, -1),
                    new AbilityAttribute(SystemShockSurvival, 45),
                    new AbilityAttribute(ResurrectionSurvival, 50),
                    new AbilityAttribute(PoisonSave, 0),
                    new AbilityAttribute(Regeneration, 0)
                }
            },
            {6, new List<AbilityAttribute>
                {
                    new AbilityAttribute(HitPointAdjustment, 0),
                    new AbilityAttribute(SystemShockSurvival, 50),
                    new AbilityAttribute(ResurrectionSurvival, 60),
                    new AbilityAttribute(PoisonSave, 0),
                    new AbilityAttribute(Regeneration, 0)
                }
            },
            {7, new List<AbilityAttribute>
                {
                    new AbilityAttribute(HitPointAdjustment, 0),
                    new AbilityAttribute(SystemShockSurvival, 55),
                    new AbilityAttribute(ResurrectionSurvival, 65),
                    new AbilityAttribute(PoisonSave, 0),
                    new AbilityAttribute(Regeneration, 0)
                }
            },
            {8, new List<AbilityAttribute>
                {
                    new AbilityAttribute(HitPointAdjustment, 0),
                    new AbilityAttribute(SystemShockSurvival, 60),
                    new AbilityAttribute(ResurrectionSurvival, 70),
                    new AbilityAttribute(PoisonSave, 0),
                    new AbilityAttribute(Regeneration, 0)
                }
            },
            {9, new List<AbilityAttribute>
                {
                    new AbilityAttribute(HitPointAdjustment, 0),
                    new AbilityAttribute(SystemShockSurvival, 65),
                    new AbilityAttribute(ResurrectionSurvival, 75),
                    new AbilityAttribute(PoisonSave, 0),
                    new AbilityAttribute(Regeneration, 0)
                }
            }
        };
        
    }
}
