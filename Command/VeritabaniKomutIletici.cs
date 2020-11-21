using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    // Komut nesnesini alıcı nesneye iletecek nesne 
    public class VeritabaniKomutIletici
    {
        public void Calistir(IKomut komut)
        {
            komut.Calistir();
        }
    }
}
