using System;
using Visitor.Visitor;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IPad iPad = new IPad("Ipad mini", "Apple");
            GalaxyTab galaxyTab = new GalaxyTab("Galaxy Tab", "Samsung");

            iPad.Accept(new WifiVisitor());
            galaxyTab.Accept(new WifiVisitor());

            iPad.Accept(new ThreeGVisitor());
            galaxyTab.Accept(new ThreeGVisitor());

            //bunun gibi baska visitor sınıfları yazarak sınıfımızı değiştirmeden
            //yeni metotlar çalıştırabilir hale getirebiliriz. 

            Console.ReadLine();

        }
    }
}
