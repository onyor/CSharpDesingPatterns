using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    /**
     * Her nesneyi üretebilir.
     * (Neyseyi oluşturma işini müşteriden fabrikaya bırakmak için bu kalıbı kullanabiliriz.)
     * Nesneyi new' leme işlemini bayiye değil fabrikaya veririz.
     * 
     */
    public interface IPhone
    {
        string getModel();
        string getBattery();
        int getWidth();
        int getHeight();
    }
}
