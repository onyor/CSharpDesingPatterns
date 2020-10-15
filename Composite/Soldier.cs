using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// 
    /// Component sınıfı
    /// 
    abstract class Soldier
    {

        protected string _name;
        protected Rank _rank;

        public Soldier(string name, Rank rank)
        {
            _name = name;
            _rank = rank;
        }

        public abstract void AddSoldier(Soldier soldier);
        public abstract void RemoveSoldier(Soldier soldier);
        public abstract void ExecuteOrder(); // Hem Leaf hemde Composite tipi için uygulanacak olan fonksiyon

    }
}
