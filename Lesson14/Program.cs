using Lesson14.Practice;
using System;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            Human boss = new Human("Vytautas");
            boss.PrintInfo();
            Company company = new Company(boss, "My company");

            company.OfficePet = new Dog("Doggo");

            company.HireWorker(new Worker("Valytojas Jonas", 460));
            company.HireWorker(new Worker("Programuotojas Zilvinas", 2500));

            company.AddClient(new Client("Kestas"));
            company.AddClient(new Client("Ona"));

            company.PrintInfo();
            Console.ReadKey();


        }
    }
}
