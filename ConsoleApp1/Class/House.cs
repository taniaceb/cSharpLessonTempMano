using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Class
{
    class House:IPrintable, IRenderable
    {
        public string Address { get; set; }

        public void Render()
        {
            Console.WriteLine("House");
        }

        public void Print()
        {
            Console.WriteLine($"Address: {Address}");
        }
        
        

    }
}
