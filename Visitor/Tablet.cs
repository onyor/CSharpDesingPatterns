using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    /// <summary>
    /// The 'Tablet' abstract class
    /// </summary>
    public abstract class Tablet
    {
        public string Model { get; set; }
        public string Brand { get; set; }

        public Tablet(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
