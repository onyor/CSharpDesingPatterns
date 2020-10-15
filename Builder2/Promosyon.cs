using System;
using System.Collections.Generic;
using System.Text;

namespace Builder2
{
    //Product
    public class Promosyon
    {
        public string UrunAdi { get; set; }
        public int PromosyonNumarasi { get; set; }
        public string CalisanProfili { get; set; }
        public override string ToString()
        {
            Console.WriteLine($"{PromosyonNumarasi} numaralı {UrunAdi} promosyonu {CalisanProfili} calışanlarına verilmiştir.");
            return "";
        }
    }
}
