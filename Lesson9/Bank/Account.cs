using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.Bank
{
    class Account
    {
        private int accountNr;
        private DateTime lastOperationDate;
        private double balance = 0;
        private double maxCredit = 0;
       // private creditAllowed, 
           // private bigestWithdrawal

        public Account (int accountNr)
        {
            this.accountNr = accountNr;
        }

        public void AddMoney(double moneyIn)
        {
            balance += moneyIn;

        }

        public void TakeMoney(double moneyOut)
        {
            if (balance + maxCredit  >= moneyOut)
            {
                balance -= moneyOut;
            }
            else
            {
                Console.WriteLine("Error, not enough money");
            }
           
        }

        public void SetMaxCredit(double newMaxCredit)
        {
            if (newMaxCredit >=0)
            {
                maxCredit = newMaxCredit;
            }

            else Console.WriteLine("Error. Cant ");
            
        }




        public void PrintDetails()
        {
            Console.WriteLine("Balance: " + balance);
        }

   

    }
}
