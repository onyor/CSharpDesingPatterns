using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mediator
{
    /// <summary>
    /// Concrete Mediator
    /// Somut Arabulucu
    /// </summary>
    public class AtaturkAirport : IAirport
    {
        // Concrete Colleague nesne örnekleri bu koleksiyonda depolanmaktadır.
        private Dictionary<string, AirlineBase> _planes;
        public AtaturkAirport()
        {
            _planes = new Dictionary<string, AirlineBase>();
        }

        #region IAirportControl Members

        /** Kontrol kulesine çevredeki uçakların kayıt olması için Register metodu kullanılır. 
         * Bu metod parametre olarak Colleague' den türeyen her hangibir Concrete Colleague nesne örnepğini alabilir.
         */
        public void Register(AirlineBase airlaneBase)
        {
            /** Hava yolu şirketine ait uçağın, kuleden yeni rota talep edebilmesi için, 
             * Concrete Colleague nesne örneğinin, Mediator referansının bildirilmesi gerekir.
             */
            if (!_planes.ContainsValue(airlaneBase))
            {
                _planes.Add(airlaneBase.FlightCode, airlaneBase);
            }

            airlaneBase.Airport = this;
        }

        /** Concrete Colleague nesne örneklerinin yeni rota talep ederken kullandıkları metod. 
         * Bu metod o anki koşullar gereği sakladığı diğer uçakların konum bilgilerinden yararlanıp bir takım sonuçlara varmaktadır. 
         * Bu sayede n tane kombinasyonun, her bir uçak tarafından ele alınması yerine, 
         * tüm bu kombinasyonlar daha az sayıya indirgenerek Mediator içerisinde değerlendirilebilmektedir.
         */
        public void GiveLandingPermission(string flightCode,string way)
        {
            // TODO: Diğer uçakların konumlarına bakılarak flightNumber için yeni bir rota önerilir. 
            // Gerekirse diğer uçaklarada farklı rotalar önerilebilir.
            // Sembolik olarak yeni bir rota belirleniyor. 
            // Bilgilendirme rotayı talep eden Concrete Colleague nesne örneğinin GetWay metoduna yapılan çağrı ile gerçekleştiriliyor.
            Thread.Sleep(250);
            Random rnd = new Random();
            _planes[flightCode].GetWay(String.Format("{0}:{1}E;{2}:{3}W", rnd.Next(1, 100).ToString(), rnd.Next(1, 100).ToString(), rnd.Next(1, 100).ToString(), rnd.Next(1, 100).ToString()));
        }

        #endregion
    }
}
