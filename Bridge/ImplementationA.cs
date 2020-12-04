using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class ImplementationA : IBridge
    {
        public string OperationImp()
        {
            return "Implementation A";
        }
    }
}
