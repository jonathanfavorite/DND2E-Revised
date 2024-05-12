namespace DND2E.CORE.Interfaces
{
    using DND2E.CORE.Interfaces.AbilityScores;
    using DND2E.CORE.Interfaces.Classes;
    using DND2E.CORE.Interfaces.Races;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICharacter : IAbilityScores
    {
        string Name { get; set; }
        int Level { get; set; }
        IRace Race { get; set; }
        IPCClass Class { get; set; }
    }
}
