using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Oyun : PrototypeOyun
    {
        public int OyunID { get; set; }
        public string OyunAdi { get; set; }
        public string OyunTuru { get; set; }
        public bool Durum { get; set; }

        public Oyun(int OyunID,string OyunAdi, string OyunTuru, bool Durum)
        {
            this.OyunID = OyunID;
            this.OyunAdi = OyunAdi;
            this.OyunTuru = OyunTuru;
            this.Durum = Durum;
        }

        public override PrototypeOyun Clone()
        {
            //O anki nesnenin MemberwiseClone metodu ile bir kopyası oluşturularak “PrototypeOyun” tipinde geri gönderilmektedir.
            return this.MemberwiseClone() as PrototypeOyun;
        }

        public override string ToString()
        {
            return base.ToString() + "\nOyun ID : " + OyunID+"\nOyun Adı : "+ OyunAdi+ "\nOyun Türü: " + OyunTuru+ "\nDurumu : " + Durum;
        }
    }
}
