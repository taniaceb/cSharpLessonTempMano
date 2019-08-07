using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson14.Practice
{
    class Worker:Human
    {
        private int _salary = 0;

        public Worker (string name, int salary):base (name)
        {

        }

        public void SetSalary(int salary)
        {
            _salary = salary;
           
        }

        public int GetSalary()
        {
            return _salary;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Worker salary: {GetSalary()}");
        }
    }
}
