using System.Windows;

namespace AtmApplicationWPF
{
    public partial class AccountMenuWindow : Window
    {
        private Account account;

        public AccountMenuWindow(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void CheckBalanceButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(account.CheckBalance());
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            DepositWindow depositWindow = new DepositWindow(account);
            depositWindow.ShowDialog();
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            WithdrawWindow withdrawWindow = new WithdrawWindow(account);
            withdrawWindow.ShowDialog();
        }

        private void DisplayTransactionsButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayTransactionsWindow displayTransactionsWindow = new DisplayTransactionsWindow(account);
            displayTransactionsWindow.ShowDialog();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
