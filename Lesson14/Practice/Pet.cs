using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson14.Practice
{
    class Pet:LiveObject,IPrintMe
    {

        public Pet(): base()
        {

        }

        public override string GetRace()
        {
            return "pet";
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Pet: {GetRace()}");
        }
    }
}
