using Lesson9_uzd_Child_Class.Nature;
using Lesson9_uzd_Child_Class.Transport;
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

            Vehicle vehicle = new Vehicle(150, 4);
            vehicle.ChangeWheel(4);
            vehicle.Move();

            Console.WriteLine("Flyer");
            Flyer flyer = new Flyer(250, 10, 250);
            flyer.Move();
            flyer.ChangeWheel(2);
            flyer.PichUp(50);
            Console.WriteLine($"Altitude:  {flyer.Altitude}");
        }
    }
}
