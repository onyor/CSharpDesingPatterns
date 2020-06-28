using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class SiparisDetaylari
    {
        public void SiparisDetaylariniEkle(int siparisId, List<SepettekiUrun> urunler)
        {
            Console.WriteLine("{0} numaralı siparişte alınan ürünler:", siparisId);
            Console.WriteLine("...............................");
            urunler.ForEach(u => Console.WriteLine("{0} ürününden {1} adet alındı. Ara toplam:{2}", u.UrunAdi, u.Adet, u.Adet * u.Fiyat));
            Console.WriteLine("...............................");
            var toplam = urunler.Sum(x => x.Fiyat * x.Adet);
            Console.WriteLine("Toplam:{0}", toplam);

        }
    }
}
