using System;

namespace Singleton
{
    class Program
    {
        /**
         * Creational design patterns grubuna ait singleton design pattern bir nesnenin application pool kapanana kadar bir kez üretilmesini ve 
         * tek bir instance’ının olmasın kontrol altında tutar. Aynı zamanda bu nesne sınıf dışından da erişilebilinir olur
         * !!! Bir sınıfın bir anda sadece bir örneğinin olması istenildiği zamanlarda kullanılır.
         */

        /**
         * Bu desenin kullanımı oldukça basittir. 
         * Singleton deseni uygulanacak sınıfın constructor(yapıcı) metodu private olarak tanımlanır ve sınıfın içinde kendi türünden static bir sınıf tanımlanır. 
         * Tanımlanan bu sınıfa erişimi sağlayacak bir metot veya property de sınıfa eklenir. 
         * Bu desenin birden fazla kullanım şekli olsa da genel anlamda bu şekilde kullanılır.
         */
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Console.WriteLine(singleton1.Id.ToString());

            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton2.Id.ToString());

            //ikisi için de aynı id gelir. çünkü tektir.
            Console.ReadKey();
        }
    }
}
