using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson15.Class
{
    class TestClass :IPrintData
    {
        //private string _name;
        //private int age;
        //private List<int> numbers;

        public TestClass()
        {

        }


        public string Name
        {    get;  set; } = "NAME1";
      

        public int Age
        { get; set; } = 18;         
               
      
        public List<int> Numbers
        { get; set;}= new List<int>();
                

        public void PrintData()
        {
            Console.WriteLine("CLASS");
            Console.WriteLine($"name  {Name}   age {Age}");

            foreach (int number in Numbers)
            {
                Console.WriteLine($"numbers: {number} ");
            }
        }

    }
}
