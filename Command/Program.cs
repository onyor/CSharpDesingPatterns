using System;

namespace Command
{
    //https://www.turkayurkmez.com/command-design-pattern/
    class Program
    {
        /// <summary>
        /// VeritabanıKomutIletici sınıfının tek yaptığına bakın! Aldığı komutun, calistir komutunu çağırıyor sadece.
        /// Fakat komut nesnesi de alıcı nesneye sahip.O da sadece alıcının ilgili metodunu çağırmakla yetiniyor.
        /// İşte tüm bu komutları yönetmek için, VeritabanıKomutIletici nesnesini kullanabiliriz.
        /// Örneğin içinde bir IKomut listesi tuttuğunu ve çalıştırılan her komutu bu listeye eklediğini düşünün. 
        /// Oldu mu size sırası takip edilebilir bir talep sırası… İster log tutmak için kullanın isterseniz makro oluşturmak.
        /// Bir eylemin iptal edilmesine mi ihtiyacınız var? 
        /// Tek yapmanız gereken VeritabanıKomutIletici sınıfı içine bir geri al (undo) metodu yazmak ve gerekeni yapmak. 
        /// İşte bu kadar.Evet dostlar. 
        /// Artık değişen süreçleri değişmeyecek mimarilere adapte etmenin en çok tercih edilen yollarından birini biliyorsunuz. 
        /// Bu da bu yazının sonlanması için iyi bir nokta.Ha tabii, istemcinin emirleri nasıl verdiğini görmek de isteyebilirsiniz.
        /// </summary>
        static void Main(string[] args)
        {
            SiparisEkleKomutu siparisEkleKomutu = new SiparisEkleKomutu(new SiparisIslemleri());
            SiparisGuncellemeKomutu siparisGuncellemeKomutu = new SiparisGuncellemeKomutu(new SiparisIslemleri());

            VeritabaniKomutIletici veritabaniIslemcisi = new VeritabaniKomutIletici();


            veritabaniIslemcisi.Calistir(siparisEkleKomutu);
            veritabaniIslemcisi.Calistir(siparisGuncellemeKomutu);

            Console.ReadLine();
        }
    }
}
