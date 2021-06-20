using System;

namespace Simple_Atm
{
    class Program
    {


        static void Main(string[] args)
        {
            Random random = new Random();
            double randomBalance = random.Next(1, 100000);
            double randomCvc = random.Next(100, 999);


            Bankcard bankcard1 = new Bankcard
            {
                BankName = "Kapital Bank",
                Balance = randomBalance,
                Pan = "5103071414532890",
                Cvc = randomCvc.ToString(),
                ExpireDate = new DateTime(2002, 11, 01),
                FullName = "Eliyev Emiraslan",
                Pin = "4230"

            };
            Bankcard bankcard2 = new Bankcard
            {
                BankName = "Kapital Bank",
                Balance = randomBalance,
                Pan = "5123824204242092",
                Cvc = randomCvc.ToString(),
                ExpireDate = new DateTime(2002, 11, 01),
                FullName = "Eliyev Emiraslan",
                Pin = "4230"

            };
            Client client1 = new Client
            {
                id = 1,
                name = "Kenan",
                surname = "Idayatov",
                bankAccount = bankcard1,
                salary = 1200.99

            };
            Client client2 = new Client
            {
                id = 2,
                name = "Nebi",
                surname = "Nebili",
                bankAccount = bankcard2,
                salary = 2000

            };
            Bank bank1 = new Bank();
            bank1.Clients = new Client[2] { client1, client2 };
            bank1.showCardBalance(bankcard1);
        }
    }
}

        
    


