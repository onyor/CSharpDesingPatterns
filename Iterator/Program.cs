using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aşağıda Main method içerisinde türetilmiş AlisverisSepeti classına ait bir nesne var ve bu nesne içerisinde bir bir dizi barındırmakta. 
             * Ancak dikkat ettiyseniz foreach döngüsünde dönmeye çalıştığımız yapı, iteratif özelliği bulunmayan normal bir class nesnesidir.
             */

            /*
                İşte IEnumerable ve IEnumerator tam da burada devreye girer. 
                İteratif özelliği olmayan nesnelere iteratif özellik kazandırarak onların foreach tarafından tanınmasını sağlar.
                Bu sınıfımızın iterator özelliği kazanması için IEnumerable veya IEnumerable<T> implemente etmeliyiz.
             */
            AlisverisSepeti sepetim = new AlisverisSepeti();

            foreach (Urun urun in sepetim)
                Console.WriteLine("Urun: {0}, Fiyat {1}", urun.Name, urun.Price);

            Console.ReadLine();
        }
    }
}
