using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson16.MyLibrary
{
    class Enemy : Unit
    {
        private readonly string _name;

        public Enemy(string name) : base()
        {
            _name = name;
        }

        public override void DoStuff()
        {

        }

        public void PrintName()
        {
            Console.WriteLine($"namespace: MyLibrary: {_name}");
        }
    }
}
