using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    interface IStrategy
    {
        public int doOperation(int number1, int number2);
    }
}
