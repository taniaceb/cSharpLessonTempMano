using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson14.Practice
{
    class Dog:Pet
    {
        private string _name;

        public Dog(string _name) : base()
        {

        }

        public override string GetRace()
        {
            return "dog";

        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Dog name:  {_name}");

        }
    }
}
