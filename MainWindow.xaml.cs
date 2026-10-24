using System.Windows;

namespace ECOMS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordInput.Password;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageText.Text = "Please enter your email and password.";
                return;
            }

            MessageText.Text = $"Hello, {email}! (real login check goes here later)";
        }
    }
}