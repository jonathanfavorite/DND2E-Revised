namespace DND2E.CORE.Constants.AbilityScores
{
    using DND2E.CORE.Models.AbilityScores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class StrengthABConstants
    {
        public const string HitProbability = "Hit Probability";
        public const string DamageAdjustment = "Damange Adjustment";
        public const string WeightAllowance = "Weight Allowance";
        public const string MaximumPress = "Max Press";
        public const string OpenDoors = "Open Doors";
        public const string BendBarsLiftGates = "Bend Bars/Lift Gates";

        public static Dictionary<int, List<AbilityAttribute>> AttributesDict = new Dictionary<int, List<AbilityAttribute>>()
        {
            {1, new List<AbilityAttribute>
                {
                    new AbilityAttribute { Name = HitProbability, Value = -5 },
                    new AbilityAttribute { Name = DamageAdjustment, Value = -4 },
                    new AbilityAttribute { Name = WeightAllowance, Value = 1 },
                    new AbilityAttribute { Name = MaximumPress, Value = 3 },
                    new AbilityAttribute { Name = OpenDoors, Value = 1 },
                    new AbilityAttribute { Name = BendBarsLiftGates, Value = 0 }
                }
            },
            {2, new List<AbilityAttribute>
                {
                    new AbilityAttribute { Name = HitProbability, Value = -5 },
                    new AbilityAttribute { Name = DamageAdjustment, Value = -4 },
                    new AbilityAttribute { Name = WeightAllowance, Value = 1 },
                    new AbilityAttribute { Name = MaximumPress, Value = 3 },
                    new AbilityAttribute { Name = OpenDoors, Value = 1 },
                    new AbilityAttribute { Name = BendBarsLiftGates, Value = 0 }
                }
            },
            {3, new List<AbilityAttribute>
                {
                    new AbilityAttribute { Name = HitProbability, Value = -5 },
                    new AbilityAttribute { Name = DamageAdjustment, Value = -4 },
                    new AbilityAttribute { Name = WeightAllowance, Value = 1 },
                    new AbilityAttribute { Name = MaximumPress, Value = 3 },
                    new AbilityAttribute { Name = OpenDoors, Value = 1 },
                    new AbilityAttribute { Name = BendBarsLiftGates, Value = 0 }
                }
            },
            {4, new List<AbilityAttribute>
                {
                    new AbilityAttribute { Name = HitProbability, Value = -3 },
                    new AbilityAttribute { Name = DamageAdjustment, Value = -2 },
                    new AbilityAttribute { Name = WeightAllowance, Value = 3 },
                    new AbilityAttribute { Name = MaximumPress, Value = 5 },
                    new AbilityAttribute { Name = OpenDoors, Value = 1 },
                    new AbilityAttribute { Name = BendBarsLiftGates, Value = 0 }
                }
            },
            {5, new List<AbilityAttribute>
                {
                    new AbilityAttribute { Name = HitProbability, Value = -3 },
                    new AbilityAttribute { Name = DamageAdjustment, Value = -2 },
                    new AbilityAttribute { Name = WeightAllowance, Value = 3 },
                    new AbilityAttribute { Name = MaximumPress, Value = 5 },
                    new AbilityAttribute { Name = OpenDoors, Value = 1 },
                    new AbilityAttribute { Name = BendBarsLiftGates, Value = 0 }
                } 
            }
        };
        
    }
}
