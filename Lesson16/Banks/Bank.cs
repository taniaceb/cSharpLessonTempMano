using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson16.Banks
{
    
    class Bank
    {
        public event EvenHandler OnAnyTransaction;
        public event EvenHandler OnMoneyAdded;



        private int _balance;
        private string _bankName;

        public Bank(string bankName, int balance)
        {
            _bankName = bankName;
            _balance = balance;
        }

        public void Add(int sum)
        {
            _balance += sum;

            if(OnMoneyAdded != null)
            {
                OnMoneyAdded("Money was added " + sum);
               
            }
            if (OnAnyTransaction != null)
            {
                OnAnyTransaction("Money was added " + sum);
            }
                
        }




    }
}
