namespace DND2E.CORE.Interfaces.Races
{
    using DND2E.CORE.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRace
    {
        PCRaces Type { get; set; }
        string Name { get; set; }
    }
}
