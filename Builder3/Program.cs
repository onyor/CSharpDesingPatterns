using System;

namespace Builder3
{
    class Program
    {
        //https://www.gencayyildiz.com/blog/c-builder-design-patternbuilder-tasarim-deseni/
        static void Main(string[] args)
        {
            YemekBuilder builder = new SuluYemekConcreteBuilder();
            YemekYapici yemekYapici = new YemekYapici();
            yemekYapici.YemekYap(builder);
            builder.Yemek.ToString();

            builder = new EtliYemekConcreteBuilder();
            yemekYapici.YemekYap(builder);
            builder.Yemek.ToString();

            Console.Read();
        }
    }
}
