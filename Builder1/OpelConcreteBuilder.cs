using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1
{
    //ConcreteBuilder Class
    public class OpelConcreteBuilder : IArabaBuilder
    {
        public OpelConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM() => araba.KM = 100;
        public override void SetMarka() => araba.Marka = "Opel";
        public override void SetModel() => araba.Model = "Astra";
        public override void SetVites() => araba.Vites = true;
    }
}
