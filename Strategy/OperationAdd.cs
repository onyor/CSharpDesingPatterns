using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class OperationAdd : IStrategy
    {
        public int doOperation(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
