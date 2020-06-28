using System;
using System.Collections.Generic;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            SiparisFacade siparisFacade = new SiparisFacade();
            List<SepettekiUrun> urunler = new List<SepettekiUrun>
            {
                new SepettekiUrun{ Id=1, UrunAdi="X", Fiyat=5, Adet=2},
                new SepettekiUrun{ Id=2, UrunAdi="Y", Fiyat=8, Adet=3},
                new SepettekiUrun{ Id=1, UrunAdi="Z", Fiyat=10, Adet=1},
                new SepettekiUrun{ Id=1, UrunAdi="Q", Fiyat=20, Adet=1}
            };
            siparisFacade.SiparisVer("Türkay", "Aras Kargo", urunler);
            Console.ReadLine();
        }
    }
}
