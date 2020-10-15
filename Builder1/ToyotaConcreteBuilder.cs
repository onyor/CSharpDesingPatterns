﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1
{
    //ConcreteBuilder Class
    public class ToyotaConcreteBuilder : IArabaBuilder
    {
        public ToyotaConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM() => araba.KM = 150;
        public override void SetMarka() => araba.Marka = "Toyota";
        public override void SetModel() => araba.Model = "Corolla";
        public override void SetVites() => araba.Vites = true;
    }
}
