using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class InterbaseFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterbaseCommand();
        }

        public override Connection CreateConnection()
        {
            return new InterbaseConnection();
        }
    }
}
