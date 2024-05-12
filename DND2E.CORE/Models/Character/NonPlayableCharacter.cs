namespace DND2E.CORE.Models.Character
{
    using DND2E.CORE.Interfaces;
    using DND2E.CORE.Interfaces.Classes;
    using DND2E.CORE.Interfaces.Races;
    using DND2E.CORE.Models.AbilityScores;
    using DND2E.CORE.Models.Classes;
    using DND2E.CORE.Models.Races;

    public class NonPlayableCharacter : INonPlayableCharacter
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;
        public AbilityScores AbilityScores { get; set; } = new AbilityScores();
        public IRace Race { get; set; } = new Human();
        public IPCClass Class { get; set; } = new Fighter();

        public override string ToString()
        {
            return $"{Name}, Lvl {Level} {Race.Name} {Class.Name}";
        }
    }
}
