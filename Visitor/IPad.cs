using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    /// <summary>
    /// The 'ConcreteElement' class
    /// </summary>
    public class IPad : Tablet
    {
        public IPad(string model, string brand)
            : base(model, brand)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
