using System;

namespace Flyweight
{
    class Program
    {
        /**
         * Flyweight pattern, nesne üretiminden kaynaklı bellek kullanımını minimize etmemizi sağlayan bir tasarım kalıbıdır. 
         * Eğer bellek tüketimi, çok fazla nesnenin bir arada ele alınmasından kaynaklı ortaya çıkıyorsa burada flyweight tasarım kalıbını kullanabiliriz.
         * 
         * Flyweight tasarım kalıbı havuz mantığıyla çok kullanılan nesnelerin creation işlemini azaltmayı sağlar!
         */

        /**
         * Flyweight tasarım kalıbının yapısına değinecek olursak, bu patternde FlyweightFactory dediğimiz bir classımız vardır. 
         * Bu class içerisinde Flyweight classının kalıtımını alan classların yani tekrar tekrar üreteceğimiz classların listesini tutar ve 
         * bir metot ile clienta bu listeye erişim verir. 
         * Client bu metot üzerinden bir nesne üretmek istediği zaman, metot önce bu nesne elindeki listede yani nesne havuzunda var mı diye bakar. 
         * Var ise bu listeden verir. Yok ise de önce bu listeye ekler sonra da eklediğini verir.
         */
        static void Main(string[] args)
        {
            // İstemci için örnek bir FlyWeight nesne örneği dizisi oluşturulur.
            SoldierType[] soldiers = { SoldierType.Private, SoldierType.Private, SoldierType.Sergeant, SoldierType.Private, SoldierType.Sergeant };

            // FlyWeight Factory nesnesi örneklernir
            SoldierFactory factory = new SoldierFactory();

            // Extrinsic değerler set edilir
            int localtionX = 10;
            int locationY = 10;

            foreach (SoldierType soldier in soldiers)
            {
                localtionX += 10;
                locationY += 5;

                // O anki Soldier tipi için MoveTo operasyonu çağırılmadan önce fabrika nesnesinden tedarik edilir
                Soldier sld = factory.GetSoldier(soldier);

                // FlyWeight nesnesi üzerinden talep edilen operasyon çağrısı gerçekleştirilir
                sld.MoveTo(localtionX, locationY);
            }
        }
    }
}

/*
 * Yani kısaca . . .

Bir nesne üretmek istediğin zaman FlyweightFactory üzerinden üret.
Eğer nesne flyweightFactroy içerisindeki havuzda yer alıyorsa nesneyi sana bu havuzdan döndürecektir. Yok ise önce havuza ekleyip sonra döndürecektir.

Havuzdaki nesnelerin common olanları havuzdan alındığı şekilde kullanılır. Spesifikasyon gerekenleri de havuzdan alındıktan sonra customize edilir.
Tabi FlyweightFactory üzerinden alacağımız nesnelerin her zaman her propertylerinin aynı değerde olmasını beklemeyiz. Bazı propertyler ortaktır. 
Bazıları da ihtiyaca göre set edilir. Burda concreteFlyweight classının sahip olduğu ortak özelliklere intrinsic, 
farklı olacak olan özelliklere de extrinsic denir. 
Instrinsic özellikler nesne havuzdan alınırken hazır verilirken extrinsic özellikler client tarafından set edilir.
 */