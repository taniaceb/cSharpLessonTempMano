using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9_uzd_Child_Class.Nature
{
    class Animal
    {
        private string _country;
        protected int lifespan;
        public string name;

        public Animal (string name, int lifespan, string country)
        {
            
            this.name = name;
           this.lifespan = lifespan;
          _country = country;
        }

        public void PrintAnimal()
        {
            Console.WriteLine($"  Animal name: {name}\r\n  Animal lifespan: {lifespan}\r\n  Animal country: {_country}");
        }
        public void GetCountry()
        {
            Console.WriteLine($"  Country: {_country}");
        }

    }
}
