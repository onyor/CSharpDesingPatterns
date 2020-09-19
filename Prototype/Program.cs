using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyun o1 = new Oyun(3, "Oyun Adı", "Oyun Türü", true);
            Oyun o2 = (Oyun)o1.Clone();

            o2.OyunID = 2;
            o2.Durum = false;

            if (o1.Equals(o2))
            {
                Console.WriteLine("Eşit");
            }
            else
            {
                //Nesneler bir birinden farklı olacağından "Değil" döner.
                Console.WriteLine("Değil");
            }

            Console.WriteLine(o1);
            Console.WriteLine("*******************");
            Console.WriteLine(o2);

            Console.Read();
        }
    }

    // https://www.gencayyildiz.com/blog/c-prototype-design-pattern-prototip-tasarim-deseni/
}
