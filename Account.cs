using System.Collections.Generic;

namespace AtmApplicationWPF
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }
        public string AccountHolderName { get; set; }
        public List<string> Transactions { get; private set; }

        public Account(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            InterestRate = interestRate;
            AccountHolderName = accountHolderName;
            Transactions = new List<string>();
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Transactions.Add($"Deposited: {amount}");
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Transactions.Add($"Withdrew: {amount}");
                return true;
            }
            else
            {
                Transactions.Add($"Failed Withdrawal: {amount}");
                return false;
            }
        }

        public string CheckBalance()
        {
            return $"Account Balance: {Balance}";
        }

        public List<string> GetTransactions()
        {
            return Transactions;
        }
    }
}
