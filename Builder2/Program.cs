using System;

namespace Builder2
{
    //https://www.gencayyildiz.com/blog/c-builder-design-patternbuilder-tasarim-deseni/
    class Program
    {
        static void Main(string[] args)
        {
            PromosyonBuilder promosyon = new AmirlerConcreteBuilder();
            PromosyonGonder gonder = new PromosyonGonder();
            gonder.Gonder(promosyon);
            promosyon.Promosyon.ToString();

            promosyon = new KadinlarConcreteBuilder();
            gonder.Gonder(promosyon);
            promosyon.Promosyon.ToString();

            Console.Read();
        }
    }
}
