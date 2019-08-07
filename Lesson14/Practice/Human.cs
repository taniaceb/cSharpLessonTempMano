using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson14.Practice
{
    class Human:LiveObject, IPrintMe
    {
        protected string _name;

        public Human (string name) : base()
        {
            _name = name;
        }

        public  override string GetRace()
        {
            return "human";
        }

        

        public virtual void PrintInfo()
        {
            Console.WriteLine($"BOSS: {GetRace()} {_name}");
        }
    }
}
