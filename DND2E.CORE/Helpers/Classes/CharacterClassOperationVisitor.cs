namespace DND2E.CORE.Helpers.Classes
{
    using DND2E.CORE.Interfaces.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CharacterClassOperationVisitor : IPCClassVisitor
    {
        public void Visit(IFighter fighter)
        {
            // do whatever we need fighters to do
            Console.WriteLine($"Preparing fighter things.");
        }

        public void Visit(IMage mage)
        {
            Console.WriteLine($"Preparing mage things.");
        }
    }
}
