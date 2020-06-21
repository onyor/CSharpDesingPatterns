using System;

namespace Factory
{
    //Phone Seller
    /**
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            IPhone s8 = PhoneFactory.getPhone("S8", "2500mah", 4, 7);

            IPhone note8 = PhoneFactory.getPhone("Note8","3500mah",5,8);

            Console.WriteLine("S8 için telefon özellikleri: ");
            Console.WriteLine(s8);

            Console.WriteLine("Note8 için telefon özellikleri: ");
            Console.WriteLine(note8);
        }

        /**
         * PhoneFactory deki getPhone() methodu static olmasaydı!!!
         */

        //static void Main(string[] args)
        //{
        //    PhoneFactory phoneFactory = new PhoneFactory();

        //    IPhone s8 = phoneFactory.getPhone("S8", "2500mah", 4, 7);

        //    IPhone note8 = phoneFactory.getPhone("Note8", "3500mah", 5, 8);

        //    Console.WriteLine("S8 için telefon özellikleri: ");
        //    Console.WriteLine(s8);

        //    Console.WriteLine("Note8 için telefon özellikleri: ");
        //    Console.WriteLine(note8);
        //}
    }
}
