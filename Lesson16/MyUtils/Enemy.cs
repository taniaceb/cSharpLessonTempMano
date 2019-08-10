using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson16.MyUtils
{
    class Enemy:IEnemy
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            } 
            set
            {
                _name = value;
            }
        }

        public void DoStuff()
        {
            Console.WriteLine($"namespace MyUtils  {_name}");
            
        }

        
    }
}
