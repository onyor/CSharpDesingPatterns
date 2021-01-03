using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Fax
    {
        //Db ile Service
        //Bu iki class aynı interfaceden türeyip, bir grup oluşturmuş vaziyette.Yani herhangi bir fonksiyonda ortak interface üzerinden değerlendirilebilirler.
        //Aşağıda ise fax adında bir classımız bulunmakta ve bu class diğer class grubundan farklı bir yapıdadır.
        //Diğer iki class Error classıdır bu class ise fax işleminden sorumludur.
        //Ancak fax işleminin içerisinde oluşabilecek Errorlar için ErrorCode ve ErrorDescription gibi propertyleri de içermektedir.
        //Yapı olarak aynı interfaceden türemedikleri için , aynı fonksiyonda interface üzerinden birlikte ele alınamazlar.
        
        public int FaxErrorCode { get; set; }
        public string ErrorDescription { get; set; }

        //Fax yolla
        void Send()
        {

        }

        //Fax al
        void Get()
        {

        }

    }
}