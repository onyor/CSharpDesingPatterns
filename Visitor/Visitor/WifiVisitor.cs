using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Visitor
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    public class WifiVisitor : IVisitor
    {
        public void Visit(Tablet tablet)
        {
            if (tablet is IPad)
                Console.WriteLine("Ipad wifi has open.");
            else if (tablet is GalaxyTab)
                Console.WriteLine("GalaxyTab does not have wifi option.");
            else
                Console.WriteLine("This object is not a tablet.");
        }
    }
}
