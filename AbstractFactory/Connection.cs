using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool Disconnect();
        public abstract string State { get; } //read-only
    }
}
