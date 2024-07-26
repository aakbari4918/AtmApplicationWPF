using System.Windows;

namespace AtmApplicationWPF
{
    public partial class MainWindow : Window
    {
        private Bank bank;

        public MainWindow()
        {
            InitializeComponent();
            bank = new Bank();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            CreateAccountWindow createAccountWindow = new CreateAccountWindow(ref bank);
            createAccountWindow.ShowDialog();
        }


        private void SelectAccountButton_Click(object sender, RoutedEventArgs e)
        {
            SelectAccountWindow selectAccountWindow = new SelectAccountWindow(bank);
            selectAccountWindow.ShowDialog();
        }


        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
