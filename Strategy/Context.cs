using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int executeStrategy(int number1,int number2)
        {
            return strategy.doOperation(number1, number2);
        }
    }
}
