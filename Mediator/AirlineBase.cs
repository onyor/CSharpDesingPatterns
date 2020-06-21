using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// Collague
    /// Meslektaş-(Uçak)
    /// </summary>
    public abstract class AirlineBase
    {
        public string FlightCode { get; set; }
        public IAirport Airport { get; set; }
        public string From { get; set; }

        // Mediator' den yani kuleden yeni bir rota talep ederken kullanılan metod.
        public void RequestNewWay(string myWay)
        {
            // Çağrı dikkat edileceği üzere Mediator tipine ait nesne referansına doğru yapılmaktadır. 
            // Peki bu referansı nerede verdik. Bknz Register metodu. :)
            Airport.GiveLandingPermission(FlightCode, myWay);
        }

        // Mediator tipinin, çağırıda bulunacağı GetWay metodu. Bu metodun parametre içeriği, 
        // kuleden(Concrete Mediator) üzerinden gelmektedir.
        public virtual void GetWay(string messageFromAirport)
        {
            Console.WriteLine("{0} rotasına yönelmemiz gerekmektedir.", messageFromAirport);
        }
    }
}
