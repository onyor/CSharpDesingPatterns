using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class PegasusAirline : AirlineBase
    {
        /// <summary>
        /// Concrete Collague
        /// Somut MeslekTaş
        /// </summary>
        public override void GetWay(string messageFromAirport)
        {
            Console.WriteLine(FlightCode + " nolu Pegasus ucagi inis icin izin gonderdi!");
            base.GetWay(messageFromAirport);
        }
    }
}