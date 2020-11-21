using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{/// <summary>
/// Üçüncü adımın anlaşılması önemli. Alıcı nesnenin yapacağı işleri doğrudan çağırmayacağız. 
/// Eğer öyle yaparsak değişecek her yapıda, bu metotlara müdahale etmemiz gerekirdi.Amaç zaten bundan kaçınmaktı.Öyleyse,
/// </summary>
    public class SiparisEkleKomutu : IKomut
    {
        private SiparisIslemleri siparisIslemleri;
        public SiparisEkleKomutu(SiparisIslemleri siparisIslemleri)
        {
            this.siparisIslemleri = siparisIslemleri;
        }

        public void Calistir()
        {
            siparisIslemleri.YeniSiparisEkle();
        }
    }
}
