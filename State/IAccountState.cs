using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    //Soyut State nesnesi
    public interface IAccountState
    {
        void WithdrawMoney();
        void PayInterest();
    }
}
