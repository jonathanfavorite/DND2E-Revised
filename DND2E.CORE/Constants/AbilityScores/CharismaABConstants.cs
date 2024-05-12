namespace DND2E.CORE.Constants.AbilityScores
{
    using DND2E.CORE.Models.AbilityScores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class CharismaABConstants
    {
        public const string MaximumNumberOfHenchman = "Maxiumum Number of Henchman";
        public const string LoyaltyBase = "Loyalty Base";
        public const string ReactionAdjustment = "Reaction Adjustment";

        public static Dictionary<int, List<AbilityAttribute>> AttributesDict = new Dictionary<int, List<AbilityAttribute>>()
        {
            {1, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 0),
                    new AbilityAttribute(LoyaltyBase, -8),
                    new AbilityAttribute(ReactionAdjustment, -7)
                }
            },
            {2, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 1),
                    new AbilityAttribute(LoyaltyBase, -7),
                    new AbilityAttribute(ReactionAdjustment, -6)
                 }
            },
            {3, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 1),
                    new AbilityAttribute(LoyaltyBase, -6),
                    new AbilityAttribute(ReactionAdjustment, -5)
                }
            },
            {4, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 2),
                    new AbilityAttribute(LoyaltyBase, -5),
                    new AbilityAttribute(ReactionAdjustment, -4)
                }
            },
            {5, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 3),
                    new AbilityAttribute(LoyaltyBase, -4),
                    new AbilityAttribute(ReactionAdjustment, -3)
                }
            },
            {6, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 4),
                    new AbilityAttribute(LoyaltyBase, -3),
                    new AbilityAttribute(ReactionAdjustment, -2)
                }
            },
            {7, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 5),
                    new AbilityAttribute(LoyaltyBase, -2),
                    new AbilityAttribute(ReactionAdjustment, -1)
                }
            },
            {8, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 6),
                    new AbilityAttribute(LoyaltyBase, -1),
                    new AbilityAttribute(ReactionAdjustment, 0)
                }
            },
            {9, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 7),
                    new AbilityAttribute(LoyaltyBase, 0),
                    new AbilityAttribute(ReactionAdjustment, 0)
                }
            },
            {10, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 8),
                    new AbilityAttribute(LoyaltyBase, 0),
                    new AbilityAttribute(ReactionAdjustment, 0)
                }
            },
            {11, new List<AbilityAttribute>
                {
                    new AbilityAttribute(MaximumNumberOfHenchman, 9),
                    new AbilityAttribute(LoyaltyBase, 0),
                    new AbilityAttribute(ReactionAdjustment, 0)
                }
            }
        };
        
    }
}
