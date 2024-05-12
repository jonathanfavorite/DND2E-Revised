namespace DND2E.CORE.Helpers.AbilityScores
{
    using DND2E.CORE.Constants.AbilityScores;
    using DND2E.CORE.Models.AbilityScores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class AbilityScoreHelper
    {
        public static List<AbilityAttribute> GetStrengthAttributes(int level)
        {
            return StrengthABConstants.AttributesDict[level];
        }
        public static List<AbilityAttribute> GetDexterityAttributes(int level)
        {
            return DexterityABConstants.AttributesDict[level];
        }
        public static List<AbilityAttribute> GetConstitutionAttributes(int level)
        {
            return ConstitutionABConstants.AttributesDict[level];
        }
        public static List<AbilityAttribute> GetIntelligenceAttributes(int level)
        {
            return IntelligenceABConstants.AttributesDict[level];
        }
        public static List<AbilityAttribute> GetWisdomAttributes(int level)
        {
            return WisdomABConstants.AttributesDict[level];
        }
        public static List<AbilityAttribute> GetCharismaAttributes(int level)
        {
            return CharismaABConstants.AttributesDict[level];
        }
    }
}
