using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    //Concrete State nesnesi - 2
    public class NormalAccount : IAccountState
    {
        public void PayInterest()
        {
            Console.WriteLine("Interest paid with Normal Account");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Money is taken with Normal Account");
        }
    }
}
