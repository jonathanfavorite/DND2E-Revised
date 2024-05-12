namespace DND2E.CORE.Interfaces.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPCClassVisitor
    {
        void Visit(IFighter fighter);
        void Visit(IMage mage);
    }
}
