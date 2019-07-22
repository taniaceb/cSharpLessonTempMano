using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.Test
{
    class TestClass
    {
        private string name;
        private string lastname = "TestLastName";
        private string city;
        private string street = "Kauno";


        public string Name
        {
            get { Console.WriteLine(name); return name;  }
            set { name = value; Console.WriteLine(name); }

        }

        public string LastName
        {
            get { Console.WriteLine(lastname); return lastname; }
        } 

        public string City
        {
            set { city = value; Console.WriteLine(city); }
         }

        public string Street
        {
            get { Console.WriteLine(street); return street; }
            private set { street = value; Console.WriteLine(street); }
        }

    }
}
