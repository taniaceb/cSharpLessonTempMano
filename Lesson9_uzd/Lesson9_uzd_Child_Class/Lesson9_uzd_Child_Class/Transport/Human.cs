using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9_uzd_Child_Class.Transport
{
    class Human
    {
        private int _age;
        public Human(int age)
        {
            _age = age;
        }

        public void Talk()
        {
            if (_age > 2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
