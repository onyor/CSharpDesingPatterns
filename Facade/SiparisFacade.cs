using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class SiparisFacade
    {
        private Musteri musteri;
        private KargoSirketi kargoSirketi;
        private UrunIslemleri urunIslemleri = new UrunIslemleri();
        private SiparisIslemleri siparisIslemleri = new SiparisIslemleri();
        private SiparisDetaylari siparisDetaylari = new SiparisDetaylari();


        public void SiparisVer(string musteriAdi, string secilenKargoSirketi, List<SepettekiUrun> urunler)
        {
            musteri = new Musteri { Ad = musteriAdi };
            kargoSirketi = new KargoSirketi { Ad = secilenKargoSirketi };
            int siparisId = siparisIslemleri.SiparisEkle(DateTime.Now, musteri, kargoSirketi);
            siparisDetaylari.SiparisDetaylariniEkle(siparisId, urunler);
            urunler.ForEach(u => urunIslemleri.StokGuncelle(u.Id, u.Adet));
            Console.WriteLine();
            Console.WriteLine("İşlem tamamlandı");
        }
    }
}
