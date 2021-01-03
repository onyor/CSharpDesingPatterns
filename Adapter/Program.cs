using System;

namespace Adapter
{
    class Program
    {
        /**
         * Adapter tasarım kalıbı bir sistem parçasını var olan sisteme adapte edilmesini ve o sistem içerisinde kullanılabilmesini sağlayan bir kalıptır. 
         * Aşağıda bununla ilgili yaptığımız örnekte IError interfacesinden türeyen DbError ve ServiceError classlarından oluşan bir class grubu ve
         * bu sisteme dahil olması geren Fax classı ve bunu gerçekleştiren FaxAdapter classı söz konusudur.
         */

        //Sistemin client tarafından çağırımı da aşağıdaki şekilde olacaktır.
        static void Main(string[] args)
        {
            Fax fax = new Fax { FaxErrorCode = 4000, ErrorDescription = "Cevap gelmiyor" };


            IError[] errors = {
                      new DbError{ErrorNumber=100,Description="Baglanti saglanamadi" },
                         new DbError{ErrorNumber=101,Description="sorgulama saglanamadi" },
                            new ServiceError{ErrorNumber=300,Description="yetki saglanamadi" },
                               new FaxAdapter(fax)
                            };

            foreach (IError error in errors)
                error.SendMail();

            Console.ReadKey();
        }
    }
}
