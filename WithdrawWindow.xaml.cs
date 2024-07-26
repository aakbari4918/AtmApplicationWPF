using System.Windows;

namespace AtmApplicationWPF
{
    public partial class WithdrawWindow : Window
    {
        private Account account;

        public WithdrawWindow(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            double amount = double.Parse(WithdrawAmountTextBox.Text);
            bool success = account.Withdraw(amount);

            if (success)
            {
                MessageBox.Show("Withdrawal successful!");
            }
            else
            {
                MessageBox.Show("Insufficient funds.");
            }
            Close();
        }
    }
}
