namespace DND2E.CORE.Interfaces.Classes.Groups
{
    using DND2E.CORE.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPCClassGroup
    {
        PCClassGroupTypes GroupType { get; set; }
        string GroupName { get; set; }
    }
}
