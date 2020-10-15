using System;
using System.Collections.Generic;
using System.Text;

namespace Builder2
{
    //Builder Class
    public abstract class PromosyonBuilder
    {
        protected Promosyon promosyon;
        public Promosyon Promosyon
        {
            get
            {
                return promosyon;
            }
        }
        public abstract void SetUrunAdi();
        public abstract void SetPromosyonNumarasi();
        public abstract void SetCalisanProfili();
    }
}
