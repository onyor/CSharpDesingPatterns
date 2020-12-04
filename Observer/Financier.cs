using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Financier : IFinancer
    {
        public string Name { get; set; }

        public void Update(Stock stock)
        {
            Console.WriteLine("{0} hissesinin lot değeri {1} olarak güncellendi", stock.Name, stock.LotValue.ToString("C2"));
        }
    }
}
