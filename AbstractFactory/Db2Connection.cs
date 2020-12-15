using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Db2Connection : Connection
    {
        public override string State { get { return "Baglanti Durumu"; } }

        public override bool Disconnect()
        {
            Console.WriteLine("Db2Baglantisi kapatilacak");
            return true;
        }

        public override bool Connect()
        {
            Console.WriteLine("Db2Baglantisi acilacak");
            return true;
        }
    }
}
