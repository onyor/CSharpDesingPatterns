using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    // FABRİKA TASARIM KALIBI

    /**
     *  static bir method' umuz olsun
     *  Bayiler(main) ve Fabrikalar(PhoneFactory) Telefon(IPhone) oluşturmasın.
     *  Fabrika(PhoneFactory) üzerinden direk static method' u çağırmaız yeterli
     *  Amacımız nesneyi oluşturma görevini Fabrikaya(PhoneFactory) verip,
     *  Bayiler(main) ile Telefon(IPhone) arasındaki ilişkiyi minumum bağımlılık ile kurmak.
     */
    public class PhoneFactory
    {
        /**
         * Eğer samsung' un bir çok modeli olsaydı ki
         * Bu static method' un içerisinde 100'lerce if bloğu olabilirdi.
         */

        public static IPhone getPhone(string model, string battery, int width, int height)
        {
            IPhone phone;
            /**
             * Her if bloğu içerisinde bir instance oluşturma işlemi gerçekleşiyor.
             */
            if ("S8".Equals(model, StringComparison.InvariantCultureIgnoreCase))
            {
                phone = new S8(model, battery, width, height);
            }
            else if ("Note8".Equals(model, StringComparison.InvariantCultureIgnoreCase))
            {
                phone = new Note8(model, battery, width, height);
            }
            else
            {
                throw new Exception("Geçerli bir model giriniz!");
            }
            return phone;
        }
    }
}
