﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.Bank
{
    class AccountManager
    {
        private Account account;
        public AccountManager(Account account)
        {
        this.account=account;
        }

        public void AddMoney (double newMoney)
        {
            account.AddMoney(newMoney);
        }
    }
}
