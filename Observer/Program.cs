using System;

namespace Observer
{
    class Program
    {
        /// <summary>
        ///  Elimizdeki mevcut nesnenin durumunda herhangi bir değişiklik olduğunda, 
        ///  bu değişiklerden diğer nesneleri haberdar eden bir tasarımdan bahsediyoruz. 
        /// </summary>

        /*
         * Observer patternin klasik örnekleri arasında finans örneği gelir. 
         * Borsacılar borsadaki herhangi bir değişimden anında haberdar olmak ister. 
         * Finans kağıtlarındaki herhangi bir değişimde tüm borsacıları uyarmak mail yahut,
         * notifikasyon göndermek istiyorsak observer tasarım deseniyle finans kağıtlarını observe edip, gerekli bildirimi yapabiliriz.
         */

        /*
         * Yukarıda bahsettiğim finans örneğini kodlamadan önce aslında observer tasarım kalıbını 
         * implemente etmek için tüm yapmamız gereken, 
         * observe etmek istediğimiz özellik değiştiğinde listenerlara bildirim yollayabilmek için, 
         * ilgili propertynin "setter" fonksiyonundan notifikasyon fonksiyonunu çağırmaktır. 
         * Böylece ilgili property ne zaman set edilirse akabinde fonksiyon da call edilecektir.
         */

        static void Main(string[] args)
        {

            Stock azonDemir = new Stock { Name = "Azon Demir Kimya", LotValue = 12.3M };

            Financier xYatirim = new Financier { Name = "X Yatırım Şirketi" };

            azonDemir.Subscribe(xYatirim); //xYatirimi güncelleme alabilmesi için abone ettik.

            Financier zBank = new Financier { Name = "z bank Şirketi" };

            azonDemir.Subscribe(zBank); //zBank güncelleme alabilmesi için abone ettik.

            Console.WriteLine("{0} hissesinin güncel lot degeri {1}", azonDemir.Name, azonDemir.LotValue.ToString("C2")+ "M");

            azonDemir.LotValue += 1;

            Console.ReadKey();
        }
    }
}
