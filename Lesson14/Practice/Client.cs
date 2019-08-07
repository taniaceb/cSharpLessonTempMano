using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson14.Practice
{
    class Client: Human
    {
        private static int clientCount = 0;
        public int ClientId { get; } = clientCount++;
        //private static string _name;

        public Client(string name) :base (name)
        {
           
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Clients");
            Console.WriteLine($"Client {GetRace()}  {_name} ID: {ClientId}" );
        }

        

    }
}
