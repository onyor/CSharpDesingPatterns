using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Alisveris a1 = new Televizyon();
            a1.TemplateMethod();

            Console.WriteLine("***********");

            Alisveris a2 = new Buzdolabi();
            a2.TemplateMethod();

            Console.Read();
        }
    }
}
