namespace DND2E.Builders
{
    using DND2E.CORE.Helpers.AbilityScores;
    using DND2E.CORE.Helpers.Classes;
    using DND2E.CORE.Interfaces;
    using DND2E.CORE.Interfaces.AbilityScores;
    using DND2E.CORE.Interfaces.Classes;
    using DND2E.CORE.Interfaces.Races;
    using DND2E.CORE.Models.AbilityScores;
    using DND2E.CORE.Models.Character;

    public class PlayableCharacterBuilder
    {
        private IPlayableCharacter _character;
        private CharacterClassOperationVisitor _visitor = new CharacterClassOperationVisitor();
        public PlayableCharacterBuilder()
        {
            _character = new PlayableCharacter();
        }
        public PlayableCharacterBuilder WithCharacter(IPlayableCharacter character)
        {
            _character = character;
            return this;
        }
        public PlayableCharacterBuilder WithName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
            }
            _character.Name = name;
            return this;
        }
        public PlayableCharacterBuilder WithClass(IPCClass pcClass)
        {
            _character.Class = pcClass;
            pcClass.Accept(_visitor);
            return this;
        }
        public PlayableCharacterBuilder WithRace(IRace race)
        {
            _character.Race = race;
            return this;
        }
        public PlayableCharacterBuilder WithLevel(int level)
        {
            if (level <= 0)
            {
                throw new ArgumentException("Level must be greater than 0.", nameof(level));
            }
            _character.Level = level;
            return this;
        }
        private void ValidateAbilityScoreAttributes()
        {
            UpdateAbilityScoreAttributes(_character.AbilityScores.Strength, AbilityScoreHelper.GetStrengthAttributes);
            UpdateAbilityScoreAttributes(_character.AbilityScores.Dexterity, AbilityScoreHelper.GetDexterityAttributes);
            UpdateAbilityScoreAttributes(_character.AbilityScores.Constitution, AbilityScoreHelper.GetConstitutionAttributes);
            UpdateAbilityScoreAttributes(_character.AbilityScores.Intelligence, AbilityScoreHelper.GetIntelligenceAttributes);
            UpdateAbilityScoreAttributes(_character.AbilityScores.Wisdom, AbilityScoreHelper.GetWisdomAttributes);
            UpdateAbilityScoreAttributes(_character.AbilityScores.Charisma, AbilityScoreHelper.GetCharismaAttributes);
        }
        private void UpdateAbilityScoreAttributes(IAbilityScore abilityScore, Func<int, List<AbilityAttribute>> getAttributes)
        {
            if (abilityScore.Attributes == null || abilityScore.Attributes.Count == 0)
            {
                abilityScore.SetAttributes(getAttributes(_character.Level));
            }
        }
        private void ValidateAll()
        {
            ValidateAbilityScoreAttributes();
        }
        public IPlayableCharacter Build()
        {
            ValidateAll();
            return _character;
        }
    }
}