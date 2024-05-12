namespace DND2E.CORE.Interfaces.Classes
{
    using DND2E.CORE.Enums;
    using DND2E.CORE.Interfaces.Classes.Groups;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPCClass : IPCClassGroup
    {
        PCClassTypes Type { get; set; }
        string Name { get; set; }
        void Accept(IPCClassVisitor visitor);
    }
}
