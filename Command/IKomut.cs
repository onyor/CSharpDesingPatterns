using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    //2. Çalıştırılacak her komutun standart bir arayüzü olmalı
    public interface IKomut
    {
        void Calistir();
    }
}
