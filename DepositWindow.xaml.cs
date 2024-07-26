using System.Windows;

namespace AtmApplicationWPF
{
    public partial class DepositWindow : Window
    {
        private Account account;

        public DepositWindow(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            double amount = double.Parse(DepositAmountTextBox.Text);
            account.Deposit(amount);
            MessageBox.Show("Deposit successful!");
            Close();
        }
    }
}
