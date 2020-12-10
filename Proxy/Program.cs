using System;

namespace Proxy
{
    /**
     * Proxy tasarım deseni çalışma maliyeti yüksek işlemlerin olduğu yapılarda, 
     * web servisi kullanılan yapılarda, 
     * remoting uygulamalarında, 
     * operasyonun gerçekleştirilmesinden önce hazırlık yapılması veya ön işlem yapılması durumlarında kullanılır. 
     * Uygulanışı basit bir tasarım desenidir. Uml diyagramı aşağıdadır.
     */

    /**
     * Aşağıdaki örnek uygulamamızın senaryosu resim gösterimi üzerine olsun. 
     * Gerçekte gösterilecek resimer büyük boyutta olsun ve kullanıcıya resmi gösterirken ilk sefer hariç, 
     * resimler yüklenirken geçen zamanı save edebilmek için proxy class yazalım. 
     * Tabi ki kodlarımızın uzamaması için sadece konsol ekranına yazı yazdıracağız. Örnek uygulamanın sınıf diyagramı aşağıdadır.
     */
    class Program
    {
        static void Main(string[] args)
        {
            ImageGeneratorProxy proxy1 = new ImageGeneratorProxy("c:\\resim1.jpg");
            ImageGeneratorProxy proxy2 = new ImageGeneratorProxy("c:\\resim2.jpg");

            proxy1.ShowImage();
            proxy2.ShowImage();
            proxy1.ShowImage();

            Console.ReadKey();
        }
    }
}
