using Lesson9_uzd_Child_Class.Nature;
using System;

namespace Lesson9_uzd_Child_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird myBird = new Bird("Bird_name",5,"Lithuania", 20, "White",true);
            myBird.PrintBird();

            Console.WriteLine();
          
            Animal animal = new Animal("Vilkas", 10, "Lithuania");
            animal.PrintAnimal();
            

        }
    }
}
