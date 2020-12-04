using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class ImplementationB : IBridge
    {
        public string OperationImp()
        {
            return "Implementation B";
        }
    }
}
