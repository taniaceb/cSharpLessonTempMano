using ConsoleApp1.Class;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero hero = new Hero();
            Dog dog = new Dog();
            Ghost ghost = new Ghost();
            House house = new House();
            Sun sun = new Sun();

            List<IPrintable> printList = new List<IPrintable>();

            List<IRenderable> allRenderables = new List<IRenderable>();

            Dog dog1 = new Dog(7, "black");
           

            dog1.Print();

        }
    }
}
