using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Liam Clarke", 12000);
            var account1 = new BankAccount("Liam Clarke", 12000);
            Console.WriteLine($"Account {account.Number} Created for {account.Owner} with balance {account.Balance}");
            Console.WriteLine($"Account {account1.Number} Created for {account1.Owner} with balance {account1.Balance}");
        }
    }
}