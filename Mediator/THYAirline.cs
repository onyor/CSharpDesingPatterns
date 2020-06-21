using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class THYAirline : AirlineBase
    {
        /// <summary>
        /// Concrete Collague
        /// Somut MeslekTaş
        /// </summary>
        public override void GetWay(string messageFromAirport)
        {
            Console.WriteLine(FlightCode + " nolu THY ucagi inis icin izin gonderdi!");
            base.GetWay(messageFromAirport);
        }
    }
}
