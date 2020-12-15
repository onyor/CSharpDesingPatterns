﻿using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    //Concrete State nesnesi - 1
    public class GoldAccount : IAccountState
    {
        public void PayInterest()
        {
            Console.WriteLine("Interest paid with Golden Account");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Money is taken with Golden Account");
        }
    }
}
