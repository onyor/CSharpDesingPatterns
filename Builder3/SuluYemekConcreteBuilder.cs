using System;
using System.Collections.Generic;
using System.Text;

namespace Builder3
{
    //ConcreteBuilder Class
    public class SuluYemekConcreteBuilder : YemekBuilder
    {
        public SuluYemekConcreteBuilder()
        {
            yemek = new Yemek();
        }
        public override void SetTuz() => yemek.Tuz = 75;
        public override void SetYemekAdi() => yemek.YemekAdi = "Çorba";
        public override void SetYemekTipi() => yemek.YemekTipi = YemekTipi.Sulu;
    }
}
