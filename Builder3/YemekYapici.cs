using System;
using System.Collections.Generic;
using System.Text;

namespace Builder3
{
    //Director Class
    public class YemekYapici
    {
        public void YemekYap(YemekBuilder builder)
        {
            builder.SetTuz();
            builder.SetYemekAdi();
            builder.SetYemekTipi();
        }
    }
}
