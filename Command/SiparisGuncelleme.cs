using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    /// <summary>
    /// Bu adımı geçmeden dikkat! SiparisEkleKomutu sınıfı, IKomut arayüzünü kullanıyor. 
    /// Böylece Calistir() metoduna sahip. Ancak bu metot, alıcının ilgili metodunu çağırmaktan başka bir şey yapmıyor. 
    /// Yani yalnızca emrin alıcısı emri uygulayabiliyor. 
    /// Alıcı nesnemizin bir de “SiparisGuncelle” işi yapabildiğini görüyoruz. O zaman bir komut nesnesi de onun için oluşturalım.
    /// </summary>
    public class SiparisGuncellemeKomutu : IKomut
    {
        private SiparisIslemleri siparisIslemleri;
        public SiparisGuncellemeKomutu(SiparisIslemleri siparisIslemleri)
        {
            this.siparisIslemleri = siparisIslemleri;
        }
        public void Calistir()
        {
            siparisIslemleri.SiparisGuncelle();
        }
    }
}
