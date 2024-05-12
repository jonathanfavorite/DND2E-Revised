namespace DND2E.CORE.Models.Classes
{
    using DND2E.CORE.Constants.Classes;
    using DND2E.CORE.Enums;
    using DND2E.CORE.Interfaces.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Mage : IMage
    {
        public PCClassTypes Type { get; set; } = PCClassTypes.Mage;
        public string Name { get; set; } = PCCharacterClassConstants.MAGE;
        public PCClassGroupTypes GroupType { get; set; } = PCClassGroupTypes.WIZARD;
        public string GroupName { get; set; } = PCCharacterClassGroupConstants.WIZARD;

        public void Accept(IPCClassVisitor visitor)
        {
            visitor.Visit(this);
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
