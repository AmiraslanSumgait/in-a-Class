using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Atm
{
    class Bank
    {
        public Client[] Clients { get; set; }
        public void showCardBalance(Bankcard bankcard)
        {

            Console.WriteLine($"Bankcard Balance:{bankcard.Balance}");
        }
        public void AddClient(Client client)
        {
            Clients = Clients.Concat(new Client[] { client }).ToArray();
        }
        public void DeleteCLient(string name)
        {
            int clientCount = Clients.Length - 1;
            Client[] clients = new Client[clientCount];
            for (int i = 0; i < Clients.Length; i++)
            {
                if (Clients[i].name!= name)
                {
                    clients[i] = Clients[i];
                }
            }
            Clients = clients;
        }
    }
}
