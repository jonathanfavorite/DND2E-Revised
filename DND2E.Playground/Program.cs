namespace DND2E.Playground
{
    using DND2E.Builders;
    using DND2E.CORE.Interfaces;
    using DND2E.CORE.Models.Classes;
    using DND2E.CORE.Models.Races;

    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayableCharacter felix = new PlayableCharacterBuilder()
               .WithName("Felix")
               .WithLevel(1)
               .WithRace(new Human())
               .WithClass(new Mage())
               .Build();

            Console.WriteLine($"Created {felix}");

            Console.ReadLine();
        }
    }
}