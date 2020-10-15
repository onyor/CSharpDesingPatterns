using System;
using System.Collections.Generic;
using System.Text;

namespace Builder1
{
    //Director Class
    public class ArabaUret
    {
        public void Uret(IArabaBuilder Araba)
        {
            Araba.SetKM();
            Araba.SetMarka();
            Araba.SetModel();
            Araba.SetVites();
        }
    }
}
