using System;

namespace Decorator
{
    /*
     * İşte yapımız hazır! Peki hem şifrelenmiş hem de imza eklenmiş bir mail nesnesi mi lazım? Alalım tabii hemen! Buyurun:
     */
    class Program
    {
        static void Main(string[] args)
        {
            string kimden = "Onur Yıldız";
            string kime = "Seçil Şahin";
            IMail standartMail = new GeneralMail(kimden, kime);
            IMail signatureMail = new AddSignatureDecorator(standartMail, "Onur Yıldız");
            IMail passwordMail = new AddPasswordDecorator(signatureMail);

            passwordMail.Send();
            Console.ReadLine();
        }
    }
    /*
     * GenelMail nesnesini imzaliMail nesnesine, imzaliMail nesnesini de sifreliMail nesnesine ekledik gördüğünüz gibi. 
     * Bu sayede, GenelMail sınıfına hiç dokunmadan, yeni iki fonksiyon eklemiş olduk. 
     * Yani Open-Closed prensibine uyan bir tasarım inşa ettik. Peki ya çıktı?
     */
}





///Süper!
///Peki siz de merak ediyor musunuz bu tasarım desenleri, .net ya da Java gibi kütüphaneler içerisinde nasıl kullanılıyor diye? 
///Eğer daha önce, herhangi bir Stream nesnesi üzerinde sıkıştırma, 
///şifreleme gibi işlemler yaptıysanız kesinlikle Decorator deseni ile geliştirilmiş sınıflardan faydalanmışsınız demektir.
///Hadi size bir hatırlatma yapayım:
///
/*
 *          var fileStream = new FileStream("result.txt", FileMode.CreateNew);
            CryptoStream cryptoStream = new CryptoStream(fileStream, new SHA512Managed(), CryptoStreamMode.Write);
            GZipStream gZipStream = new GZipStream(cryptoStream, CompressionMode.Compress);
            BufferedStream bufferedStream = new BufferedStream(gZipStream, 64);
            using (bufferedStream)
            {
                foreach (var item in Encoding.Unicode.GetBytes("Deneme"))
                {
                    bufferedStream.WriteByte(item);
                }
            }
 */
/// 
/// Dikkat ettiniz mi? CryptoStream, GzipStream ve BufferedStream sınıfları bir Decorator sınıfından başka bir şey değil. 
/// Hepsini oluştururken bir Stream nesnesi veriyorum ve hepsinin bu nesneye erişen ortak metotları var.