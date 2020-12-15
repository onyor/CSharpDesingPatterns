using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class InterbaseConnection : Connection
    {
        public override string State { get { return "Open"; } }

        public override bool Disconnect()
        {
            Console.WriteLine("interbase kapatilacak");
            return true;
        }

        public override bool Connect()
        {
            Console.WriteLine("interbase acilacak");
            return true;
        }

    }
}
