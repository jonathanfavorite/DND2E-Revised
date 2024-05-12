namespace DND2E.CORE.Models.AbilityScores
{
    using DND2E.CORE.Interfaces.AbilityScores;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AbilityScores
    {
        public IStrengthAB Strength { get; set; } = new StrengthAB();
        public IDexterityAB Dexterity { get; set; } = new DexterityAB();
        public IConstitutionAB Constitution { get; set; } = new ConstitutionAB();
        public IIntelligenceAB Intelligence { get; set; } = new IntelligenceAB();
        public IWisdomAB Wisdom { get; set; } = new WisdomAB();
        public ICharismaAB Charisma { get; set; } = new CharismaAB();
        public override string ToString()
        {
            return $"Str: {Strength.Value}, Dex: {Dexterity.Value}, Con: {Constitution.Value}, Int: {Intelligence.Value}, Wis: {Wisdom.Value}, Cha: {Charisma.Value}";
        }
    }
}
