using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class UrunIslemleri
    {
        public void StokGuncelle(int urunId, int adet)
        {
            Console.WriteLine("{0} id'li ürünün stoğundan, {1} adet düşüldü.", urunId, adet);
        }
    }
}
