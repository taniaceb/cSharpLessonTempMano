using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson14.Practice
{
    class Company : IPrintMe
    {

        private Human _boss;
        private readonly string _name;
        private List<Client> clientList = new List<Client>();
        private List<Worker> workerList = new List<Worker>();

        public Pet OfficePet { get; set; }

        public Company (Human hum, string name)
        {

        }

        public void AddClient(Client client)
        {
            clientList.Add(client);
        }

        public void FireWorker(Worker worker)
        {
            workerList.Remove(worker);

        }

        public void HireWorker(Worker worker)
        {
            workerList.Add(worker);
            
        }

        public void PrintAllClients()
        {
            foreach(Client client in clientList)
            {
               client.PrintInfo();
            }
        }
        public void PrintAllWorkers()
        {
            foreach (Worker worker in workerList)
            {
                worker.PrintInfo();
            }
        }

        public  void PrintInfo()
        {
            PrintAllClients();
            PrintAllWorkers();
        }


    }
}
