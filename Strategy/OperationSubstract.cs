using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class OperationSubstract : IStrategy
    {
        public int doOperation(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
