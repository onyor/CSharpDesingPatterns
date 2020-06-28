using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    // ARACI TASARIM KALIBI


    /// <summary>
    /// Mediator
    /// Arabulucu (Kule)
    /// </summary>
    public interface IAirport
    {
        //Uçağı Kaydet
        void Register(AirlineBase airlaneBase);

        //İniş İzni Ver
        void GiveLandingPermission(string flightCode,string way);
    }
}
