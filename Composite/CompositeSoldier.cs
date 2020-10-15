using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// 
    /// Composite Class
    /// 
    class CompositeSoldier : Soldier
    {


        // Composite tip kendi içerisinde birden fazla Component tipi içerebilir. Bu tipleri bir koleksiyon içerisinde tutabilir.
        private List<Soldier> _soldiers = new List<Soldier>();

        public CompositeSoldier(string name, Rank rank) : base(name, rank)
        {

        }

        // Composite tipin altına bir Component eklemek için kullanılır
        public override void AddSoldier(Soldier soldier)
        {
            _soldiers.Add(soldier);
        }

        // Composite tipin altındaki koleksiyon içerisinden bir Component tipinin çıkartmak için kullanılır
        public override void RemoveSoldier(Soldier soldier)
        {
            _soldiers.Remove(soldier);
        }

        // Önemli nokta. Composite tip içerisindeki bu operasyon, Composite tipe bağlı tüm Component'ler için gerçekleştirilir.
        public override void ExecuteOrder()
        {
            Console.WriteLine(String.Format("{0} {1}", _rank, _name));

            foreach (Soldier soldier in _soldiers)
            {
                soldier.ExecuteOrder();
            }

        }
    }
}
