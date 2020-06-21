using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    // ARACI TASARIM KALIBI


    /// <summary>
    /// Mediator
    /// </summary>
    public interface IAirport
    {
        void Register(AirlineBase airlaneBase);
        void GiveLandingPermission(string flightCode,string way);
    }
}
