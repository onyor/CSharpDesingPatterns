using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Command
    {
        public abstract void Execute(string query);
    }
}
