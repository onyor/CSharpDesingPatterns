using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {

            Stock azonDemir = new Stock { Name = "Azon Demir Kimya", LotValue = 12.3M };

            Financier xYatirim = new Financier { Name = "X Yatırım Şirketi" };

            azonDemir.Subscribe(xYatirim); //xYatirimi güncelleme alabilmesi için abone ettik.

            Financier zBank = new Financier { Name = "z bank Şirketi" };

            azonDemir.Subscribe(xYatirim); //zBank güncelleme alabilmesi için abone ettik.

            Console.WriteLine("{0} hissesinin güncel lot degeri {1}", azonDemir.Name, azonDemir.LotValue.ToString("C2"));

            azonDemir.LotValue += 1;

            Console.ReadKey();
        }
    }
}
