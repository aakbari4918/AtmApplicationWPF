using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AtmApplicationWPF
{
    public partial class CreateAccountWindow : Window
    {
        private Bank bank;

        public CreateAccountWindow(ref Bank _bank)
        {
            InitializeComponent();
            AddPlaceholderText();
            bank = _bank;
        }

        private void AddPlaceholderText()
        {
            AccountNumberTextBox.Text = "Account Number";
            AccountNumberTextBox.Foreground = Brushes.Gray;

            AccountHolderTextBox.Text = "Account Holder Name";
            AccountHolderTextBox.Foreground = Brushes.Gray;

            InitialDepositTextBox.Text = "Initial Deposit";
            InitialDepositTextBox.Foreground = Brushes.Gray;

            InterestRateTextBox.Text = "Intrest Rate";
            InterestRateTextBox.Foreground = Brushes.Gray;
        }

        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Account Number" || textBox.Text == "Account Holder Name" || textBox.Text == "Initial Deposit" || textBox.Text == "Intrest Rate")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == AccountNumberTextBox)
                {
                    textBox.Text = "Account Number";
                }
                else if (textBox == AccountHolderTextBox)
                {
                    textBox.Text = "Account Holder Name";
                }
                else if (textBox == InitialDepositTextBox)
                {
                    textBox.Text = "Initial Deposit";
                }
                else if (textBox == InterestRateTextBox)
                {
                    textBox.Text = "Interest Rate";
                }
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            //int accountNumber = int.Parse(AccountNumberTextBox.Text);
            //double initialBalance = double.Parse(InitialBalanceTextBox.Text);
            //double interestRate = double.Parse(InterestRateTextBox.Text);
            //string accountHolderName = AccountHolderNameTextBox.Text;

            //Account newAccount = new Account(accountNumber, initialBalance, interestRate, accountHolderName);
            //bank.AddAccount(newAccount);

            //MessageBox.Show("Account created successfully!");
            //Close();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            int accountNumber = int.Parse(AccountNumberTextBox.Text);
            double initialBalance = double.Parse(InitialDepositTextBox.Text);
            double interestRate = double.Parse(InterestRateTextBox.Text);
            string accountHolderName = AccountHolderTextBox.Text;

            Account newAccount = new Account(accountNumber, initialBalance, interestRate, accountHolderName);
            bank.AddAccount(newAccount);

            MessageBox.Show("Account created successfully!");
            Close();
        }
    }
}
