namespace DND2E.CORE.Models.Classes
{
    using DND2E.CORE.Constants.Classes;
    using DND2E.CORE.Enums;
    using DND2E.CORE.Interfaces.Classes;

    public class Fighter : IFighter
    {
        public PCClassTypes Type { get; set; } = PCClassTypes.Fighter;
        public string Name { get; set; } = PCCharacterClassConstants.FIGHTER;
        public PCClassGroupTypes GroupType { get; set; } = PCClassGroupTypes.WARRIOR;
        public string GroupName { get; set; } = PCCharacterClassGroupConstants.WARRIOR;
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
