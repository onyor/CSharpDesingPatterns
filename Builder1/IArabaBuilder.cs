﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1
{
    public abstract class IArabaBuilder
    {
        protected Araba araba;
        public Araba Araba
        {
            get { return araba; }
        }
        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();
        public abstract void SetVites();
    }
}
