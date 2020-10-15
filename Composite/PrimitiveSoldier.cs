using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// 
    /// Leaf class
    /// 
    class PrimitiveSoldier : Soldier
    {

        public PrimitiveSoldier(string name, Rank rank) : base(name, rank)
        {

        }

        // Bu fonksiyonun Leaf için anlamı yoktur.
        public override void AddSoldier(Soldier soldier)
        {
            throw new NotImplementedException();
        }

        // Bu fonksiyonun Leaf için anlamı yoktur.
        public override void RemoveSoldier(Soldier soldier)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteOrder()
        {
            Console.WriteLine(String.Format("{0} {1}", _rank, _name));
        }

    }
}
