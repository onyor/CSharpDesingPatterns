using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kule nesnesi örneklenir(Concrete Mediator)
            AtaturkAirport ataturkAirport = new AtaturkAirport();

            // Kuleden hizmet alacak tüm uçakların kendisini kuleye bildirmesi gerekmektedir. 
            // Bu nedenle uçaklar örneklendikten sonra Concrete Mediator tipine Register method yardımıyla kayıt olurlar.
            THYAirline thy01 = new THYAirline { Airport = ataturkAirport, FlightCode = "thy01", From = "Hawai" };
            ataturkAirport.Register(thy01);
            THYAirline thy02 = new THYAirline { Airport = ataturkAirport, FlightCode = "thy02", From = "Roma" };
            ataturkAirport.Register(thy02);
            PegasusAirline pgs01 = new PegasusAirline { Airport = ataturkAirport, FlightCode = "pgs01", From = "New Zeland" };
            ataturkAirport.Register(pgs01);

            // Uçaklar yeni rotalarını talep ederler.
            thy01.RequestNewWay("34:43E;41:41W");
            thy02.RequestNewWay("45:42E;68:29W");
            pgs01.RequestNewWay("86:31E;37:13W");
            
            /*  DENEMELER

            Console.WriteLine(ataturkAirport._planes[thy01.FlightCode].ToString());

            foreach (var item in ataturkAirport._planes)
            {
                Console.WriteLine(item);
            }

            */
            
        }
    }
}