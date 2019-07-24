using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Class
{
    class Dog:IPrintable, IMovable,ISpeaks
    {
        public string Name{ get;set;}
        public int X { get; set; }
        public int Y { get; set; }
        private readonly int _age;
        private readonly string _color;

        public Dog()
        {
            
        }

        public Dog(int age, string color)
        {
            _age = age;
            _color = color;
        }

       
        public void Move()
        {
            X += 2;
            Y += 2;
        }

        public void Speak()
        {
            Console.WriteLine("Au Au Au");
        }

        public void Print()
        {
            Console.WriteLine($"Dog name: {Name}");
            Console.WriteLine($"Dog age: {_age}");
            Console.WriteLine($"Dog color: {_color}");
        }

      

    }
}
