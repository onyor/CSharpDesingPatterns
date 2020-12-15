using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    //State değişimlerini yöneten ve statelere göre davranışları değişen context nesnesi  
    public class Account
    {
        private IAccountState _accountState;

        public Account()
        {
            _accountState = new NormalAccount();
        }

        public void PayInterest()
        {
            _accountState.PayInterest();
        }

        public void WithdrawMoney()
        {
            _accountState.WithdrawMoney();
        }

        public void ChangeStatus()
        {
            _accountState = new GoldAccount();
        }
    }
}
