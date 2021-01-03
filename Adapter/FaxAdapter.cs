using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /**
     * Ancak aynı anda ele alınmak istenildikleri durumlar olabilir. "Fax ile (Db & Service)"
     * Örneğin , yapıya dahil tüm errorlar bir kerede değerlendirilmek isteniyorsa ve buna fax ile ilgili errorlarda dahilse bu grup dışındaki
     * classında diğer error grubuna dahil olması yani adapte olması gerekir. Adapter design patternida tam da burada devreye girer.
     * Yapmamız gereken şey FaxAdapter isminde bir adapter classı tanımlamak ve bunu IErrordan türetmek. 
     * Böylece FaxAdapter sınıfımız diğer error grubuna dahil olabilecek. 
     * Faxadapter sınıfımıza orjinal fax sınıfımızdan bir nesne üreterek , IErrordan kalıttığımız metotlar içerisinde ilgili fax classı metotlarını çağırırız.
     * Aşağıda da görüldüğü gibi IErrordan gelen ErrorNumber orjinal fax classındaki FaxErrorCode’a, 
     * yine IError sınıfından gelen Description propertysi de orjinal fax classındaki ErrorDescription’a aracılık etmektedir. 
     * Yani aslında FaxAdapter classı  Fax classı IError sınıfından türeyen gruba adapte olabilsin diye aracılık eder.
     */
    public class FaxAdapter : IError
    {
        private Fax _fax;

        public FaxAdapter(Fax fax)
        {
            _fax = fax;
        }

        public int ErrorNumber
        {
            get { return _fax.FaxErrorCode; }
            set { _fax.FaxErrorCode = value; }
        }

        public string Description
        {
            get { return _fax.ErrorDescription; }
            set { _fax.ErrorDescription = value; }
        }

        public void SendMail()
        {
            Console.WriteLine("{0} {1} Fax hatasi alindi ", ErrorNumber.ToString(), Description);
        }
    }
}
