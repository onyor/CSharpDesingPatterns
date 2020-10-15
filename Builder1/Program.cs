using System;

namespace Builder1
{
    //https://www.gencayyildiz.com/blog/c-builder-design-patternbuilder-tasarim-deseni/
    class Program
    {
        static void Main(string[] args)
        {
            IArabaBuilder araba = new OpelConcreteBuilder();
            ArabaUret uret = new ArabaUret();
            uret.Uret(araba);

            Console.WriteLine(araba.Araba.ToString());

            araba = new ToyotaConcreteBuilder();
            uret.Uret(araba);
            Console.WriteLine(araba.Araba.ToString());

            Console.Read();
        }
    }
}
