using System;
using System.Collections.Generic;
using System.Text;

namespace Builder3
{
    //Product
    public class Yemek
    {
        public YemekTipi YemekTipi { get; set; }
        public string YemekAdi { get; set; }
        public double Tuz { get; set; }
        public override string ToString()
        {
            Console.WriteLine($"{YemekTipi} \n-> Yemek Adı : {YemekAdi} \n-> Tuz Oranı : {Tuz}");
            return base.ToString();
        }
    }
}
