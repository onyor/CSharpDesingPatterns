using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Db2Factory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new Db2Command();
        }

        public override Connection CreateConnection()
        {
            return new Db2Connection();
        }
    }
}
