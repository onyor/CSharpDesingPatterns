using System;

namespace Bridge
{
    //Bridge tasarım deseni implementasyonları abstractlardan ayırabilmek için kullanılır.

    /**
     * NE ZAMAN BRIDGE TASARIM DESENİ KULLANMALIYIM ?
     
     * İmplementasyonları clienttan tamamen ayırmak istiyorsanız…
     * İmplementasyonları direkt olarak clientla iletişime geçen abstractiona bağlamak istemiyorsanız…
     * Abstraction classını rebuild dahi etmeden implementasyonlar içerisinde değişiklik yapmak istiyorsanız…
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern \n");
            Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
            Console.WriteLine(new Abstraction(new ImplementationB()).Operation());

            Console.ReadKey();
        }
    }
}
