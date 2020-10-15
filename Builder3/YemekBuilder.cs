using System;
using System.Collections.Generic;
using System.Text;

namespace Builder3
{
    //Builder Class
    public abstract class YemekBuilder
    {
        protected Yemek yemek;

        public Yemek Yemek
        {
            get { return yemek; }
        }
        public abstract void SetYemekTipi();
        public abstract void SetYemekAdi();
        public abstract void SetTuz();
    }
}
