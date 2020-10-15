using System;
using System.Collections.Generic;
using System.Text;

namespace Builder2
{
    //Director Class
    public class PromosyonGonder
    {
        public void Gonder(PromosyonBuilder builder)
        {
            builder.SetCalisanProfili();
            builder.SetPromosyonNumarasi();
            builder.SetUrunAdi();
        }
    }
}
