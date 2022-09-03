using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get
            {
                decimal balance = 0;
                foreach (var item in allTransactions) {
                    balance += item.Amount;
                }
                return balance;
            } set
            {

            }
        }

        private List<Transaction> allTransactions = new List<Transaction>();
        private static int accountNumberSeed = 123467890;

        public BankAccount(string name, decimal initialBalance) {
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit (decimal ammount, DateTime date, string note)
        {
            if(ammount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ammount), "Ammount of deposit must be positive");
            }
            var deposit = new Transaction(ammount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal ammount, DateTime date, string note)
        {
            if(ammount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ammount), "Ammount of withdrawal must be positive");
            }
            if (this.Balance - ammount >= 0)
            {

            }
        }

    }
}
