using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class InterbaseCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("interbase Sorgusu çalıştırılır");
        }
    }
}
