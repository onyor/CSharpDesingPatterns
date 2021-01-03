using System;

namespace Template
{
    abstract class Alisveris
    {
        protected string UrunAdi;
        protected OdemeTipi odemeTipi;
        void Baslat()
        {
            Console.WriteLine("Alışveriş başladı.");
        }
        void Bitir()
        {
            Console.WriteLine($"Alışveriş bitti.{UrunAdi} {odemeTipi} yöntemiyle alınmıştır.");
        }
        abstract public void Urun();
        abstract public void OdemeSekli();
        public void TemplateMethod()
        {
            Baslat();
            Urun();
            OdemeSekli();
            Bitir();
        }
    }
}
