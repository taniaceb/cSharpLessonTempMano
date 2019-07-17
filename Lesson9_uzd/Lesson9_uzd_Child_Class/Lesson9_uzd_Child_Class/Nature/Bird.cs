using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9_uzd_Child_Class.Nature
{
    class Bird : Animal 
    {
        private int _size;
        protected string color;
        public bool isFly;
        //private string _lifespan;

      public Bird(string name,int lifespan, string country, int size, string color, bool isFly) : base(name, lifespan, country)
        {
            _size = size;
            this.color = color;
            this.isFly = isFly;
            base.lifespan = lifespan;
            
        }

        public void PrintBird()
        {
            Console.WriteLine($"  Bird name:  {name}\r\n  Bird lifespan: {lifespan}\r\n  Bird size:  {_size}\r\n  Bird color: {color}\r\n  Is Bird fly: {isFly} ");
            
            GetCountry();

        }

    }
}
