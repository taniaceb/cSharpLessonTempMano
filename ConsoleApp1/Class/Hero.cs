using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Class
{
    class Hero: IPrintable, IMovable,ISpeaks
    {
        //private int _x;
        //private int _y;

        public int X { get; set; }
        public int Y { get; set; }

        public void Move()
        {
            X += 4;
            Y += 1;
        }

        public void Speak()
        {
            Console.WriteLine("I can speak");
        }

        public void Print()
        {
            Console.WriteLine($"X:{X}, Y:{Y}");
        }


       


    }
}
