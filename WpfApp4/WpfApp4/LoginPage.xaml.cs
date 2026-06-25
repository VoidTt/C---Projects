using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    public partial class LoginPage : Page
    {
        Frame frame;

        public LoginPage(Frame f)
        {
            InitializeComponent();
            frame = f;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == User.Login && tbPassword.Password == User.Password)
            {
                frame.Navigate(new ProfilePage(frame));
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new RegisterPage(frame));
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == User.Login &&
               tbPassword.Password == User.Password)
            {
                frame.Navigate(new ProfilePage(frame));
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }

}