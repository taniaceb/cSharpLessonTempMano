using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Class
{
    class Sun:IPrintable, IGlows
    {
        public int Month { get; set; }

        public void Glow()
        {
            if (Month >5 && Month <9)
            {
                Console.WriteLine("hot");
            }
            else
            {
                Console.WriteLine("cold");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Sun month: {Month}");
        }


    }
}
