using System.Collections.Generic;
using System.Linq;

namespace AtmApplicationWPF
{
    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            accounts = new List<Account>();
            // Create 10 default accounts
            for (int i = 0; i < 10; i++)
            {
                accounts.Add(new Account(100 + i, 100.0, 0.03, $"Default User {i}"));
            }
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public Account RetrieveAccount(int accountNumber)
        {
            return accounts.FirstOrDefault(acc => acc.AccountNumber == accountNumber);
        }
    }
}
