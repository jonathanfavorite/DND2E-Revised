namespace DND2E.CORE.Models.Races
{
    using DND2E.CORE.Constants.Races;
    using DND2E.CORE.Enums;
    using DND2E.CORE.Interfaces.Races;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Elf : IHuman
    {
        public PCRaces Type { get; set; } = PCRaces.ELF;
        public string Name { get; set; } = RacesConstants.ELF;
    }
}
