using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //istemcinin ihtiyacı olan ürünlerin üretilmesi
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
