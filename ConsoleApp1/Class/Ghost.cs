using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Class
{
    class Ghost:IPrintable, IMovable
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        

        public void Move()
        {
            X += 2;
            Y += 3;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name} Street: {Street}  HouseNumber {HouseNumber}");
        }

       
    }
}
