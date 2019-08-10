using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson15.Class
{
    class TestStruct :IPrintData
    {

        public string Name;
        public int Age;
        public List<int> Numbers;

        public TestStruct(string name)
        {
            this.Name = name;
            Age = 18;
            Numbers = new List<int>();
        }
        public void PrintData()
        {
            Console.WriteLine("STRUCT");
            Console.WriteLine($"name  {Name}   age {Age}");

            foreach (int number in Numbers)
            {
                Console.WriteLine($"numbers: {number} ");
            }

        }
    }
}
