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

    public class Halfling : IHuman
    {
        public PCRaces Type { get; set; } = PCRaces.HALFLING;
        public string Name { get; set; } = RacesConstants.HALFLING;
    }
}
