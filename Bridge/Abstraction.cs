using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Abstraction
    {
        IBridge bridge;

        public Abstraction(IBridge Implementation)
        { bridge = Implementation; }

        public string Operation()
        {
            return "Abstraction <> " + bridge.OperationImp();
        }
    }
}
