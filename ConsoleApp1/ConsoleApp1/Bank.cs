using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bank
    {
        public Client[]clients { get; set; }
        public void showCardBalance(Bankcard bankcard)
        {

            Console.WriteLine($"Bankcard Balance:{bankcard.Balance}");
        }
        public   void AddClient(Client client)
        {
            clients.Length = clients.Length + 1;
        }
    }
}
