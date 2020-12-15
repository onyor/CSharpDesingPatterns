using System;

namespace AbstractFactory
{
    class Program
    {
        /**
         * Factory Method D.P.; ilişkisel olan birden fazla nesnenin üretimini ortak bir arayüz aracılığıyla 
         * tek bir sınıf üzerinden yapılacak bir talep ile gerçekleştirmek ve nesne üretim anında istemcinin üretilen 
         * nesneye olan bağımlılığını sıfıra indirmeyi hedeflemektedir.
         * 
         * Abstract Factory D.P. ise ilişkisel olan birden fazla nesnenin üretimini tek bir arayüz tarafından değil her ürün ailesi için
         * farklı bir arayüz tanımlayarak sağlamaktadır.
         * Yani anlayacağınız birden fazla ürün ailesi ile çalışmak zorunda kaldığımız durumlarda, 
         * istemciyi bu yapılardan soyutlamak için Abstract Factory D.P. doğru bir yaklaşım olacaktır.
         */
        static void Main(string[] args)
        {
            DatabaseFactory database = new Db2Factory();
            Factory factory = new Factory(database);

            factory.Start();
            
        }
    }
}
