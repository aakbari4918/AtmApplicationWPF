using System.Windows;

namespace AtmApplicationWPF
{
    public partial class SelectAccountWindow : Window
    {
        private Bank bank;

        public SelectAccountWindow(Bank bank)
        {
            InitializeComponent();
            this.bank = bank;
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            int accountNumber = int.Parse(AccountNumberTextBox.Text);
            Account selectedAccount = bank.RetrieveAccount(accountNumber);

            if (selectedAccount != null)
            {
                AccountMenuWindow accountMenuWindow = new AccountMenuWindow(selectedAccount);
                accountMenuWindow.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Account not found.");
            }
        }
    }
}
