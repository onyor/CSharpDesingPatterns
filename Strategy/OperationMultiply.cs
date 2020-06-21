using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class OperationMultiply : IStrategy
    {
        public int doOperation(int number1, int number2)
        {
            return number2 * number1;
        }
    }
}
