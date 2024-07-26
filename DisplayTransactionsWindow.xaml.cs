using System.Windows;

namespace AtmApplicationWPF
{
    public partial class DisplayTransactionsWindow : Window
    {
        private Account account;

        public DisplayTransactionsWindow(Account account)
        {
            InitializeComponent();
            this.account = account;
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            foreach (var transaction in account.GetTransactions())
            {
                TransactionsListBox.Items.Add(transaction);
            }
        }
    }
}
