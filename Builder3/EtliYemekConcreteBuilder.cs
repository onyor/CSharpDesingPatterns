using System;
using System.Collections.Generic;
using System.Text;

namespace Builder3
{
    //ConcreteBuilder Class
    public class EtliYemekConcreteBuilder : YemekBuilder
    {
        public EtliYemekConcreteBuilder()
        {
            yemek = new Yemek();
        }
        public override void SetTuz() => yemek.Tuz = 65;
        public override void SetYemekAdi() => yemek.YemekAdi = "Etli Pilav";
        public override void SetYemekTipi() => yemek.YemekTipi = YemekTipi.Etli;
    }
}
