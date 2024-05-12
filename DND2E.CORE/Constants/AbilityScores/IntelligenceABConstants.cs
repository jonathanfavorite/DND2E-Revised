namespace DND2E.CORE.Constants.AbilityScores
{
    using DND2E.CORE.Models.AbilityScores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class IntelligenceABConstants
    {
        public const string NumberOfLanguages = "Number of Languages";
        public const string SpellLevel = "Spell Level";
        public const string ChanceToLearnSpell = "Chance to Learn Spell";
        public const string MaxSpellLevel = "Max Spell Level";
        public const string IllusionImmunity = "Illusion Immunity";

        public static Dictionary<int, List<AbilityAttribute>> AttributesDict = new Dictionary<int, List<AbilityAttribute>>()
        {
            {1, new List<AbilityAttribute>
                {
                    new AbilityAttribute(NumberOfLanguages, 0),
                    new AbilityAttribute(SpellLevel, 0),
                    new AbilityAttribute(ChanceToLearnSpell, 0),
                    new AbilityAttribute(MaxSpellLevel, 0),
                    new AbilityAttribute(IllusionImmunity, 0)
                }
            },
            {2, new List<AbilityAttribute>
                {
                    new AbilityAttribute(NumberOfLanguages, 1),
                    new AbilityAttribute(SpellLevel, 0),
                    new AbilityAttribute(ChanceToLearnSpell, 0),
                    new AbilityAttribute(MaxSpellLevel, 0),
                    new AbilityAttribute(IllusionImmunity, 0)
                }
            },
            {3, new List<AbilityAttribute>
                {
                    new AbilityAttribute(NumberOfLanguages, 1),
                    new AbilityAttribute(SpellLevel, 0),
                    new AbilityAttribute(ChanceToLearnSpell, 0),
                    new AbilityAttribute(MaxSpellLevel, 0),
                    new AbilityAttribute(IllusionImmunity, 0)
                }
            },
            {4, new List<AbilityAttribute>
                {
                    new AbilityAttribute(NumberOfLanguages, 2),
                    new AbilityAttribute(SpellLevel, 0),
                    new AbilityAttribute(ChanceToLearnSpell, 0),
                    new AbilityAttribute(MaxSpellLevel, 0),
                    new AbilityAttribute(IllusionImmunity, 0)
                }
            },
            {5, new List<AbilityAttribute>
                {
                    new AbilityAttribute(NumberOfLanguages, 2),
                    new AbilityAttribute(SpellLevel, 0),
                    new AbilityAttribute(ChanceToLearnSpell, 0),
                    new AbilityAttribute(MaxSpellLevel, 0),
                    new AbilityAttribute(IllusionImmunity, 0)
                }
            },
            {6, new List<AbilityAttribute>
                {
                    new AbilityAttribute(NumberOfLanguages, 3),
                    new AbilityAttribute(SpellLevel, 0),
                    new AbilityAttribute(ChanceToLearnSpell, 0),
                    new AbilityAttribute(MaxSpellLevel, 0),
                    new AbilityAttribute(IllusionImmunity, 0)
                }
            },
            {7, new List<AbilityAttribute>
                {
                    new AbilityAttribute(NumberOfLanguages, 3),
                    new AbilityAttribute(SpellLevel, 0),
                    new AbilityAttribute(ChanceToLearnSpell, 0),
                    new AbilityAttribute(MaxSpellLevel, 0),
                    new AbilityAttribute(IllusionImmunity, 0)
                }
            },
            {8, new List<AbilityAttribute>
                {
                    new AbilityAttribute(NumberOfLanguages, 4),
                    new AbilityAttribute(SpellLevel, 1),
                    new AbilityAttribute(ChanceToLearnSpell, 35),
                    new AbilityAttribute(MaxSpellLevel, 0),
                    new AbilityAttribute(IllusionImmunity, 0)
                }
            }
        };
    }
}
