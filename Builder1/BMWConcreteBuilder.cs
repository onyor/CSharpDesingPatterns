using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1
{
    //ConcreteBuilder Class
    public class BMWConcreteBuilder : IArabaBuilder
    {
        
        public BMWConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM() => araba.KM = 25;
        public override void SetMarka() => araba.Marka = "BMW";
        public override void SetModel() => araba.Model = "X Bilmem Kaç";
        public override void SetVites() => araba.Vites = true;
    }
}
