using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    public partial class RegisterPage : Page
    {

        Frame frame;


        public RegisterPage(Frame f)
        {
            InitializeComponent();
            frame = f;
        }


        private void Create_Click(object sender, RoutedEventArgs e)
        {

            if (tbLogin.Text == "" || tbPassword.Password == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }


            User.Login = tbLogin.Text;
            User.Password = tbPassword.Password;


            MessageBox.Show("Аккаунт создан");


            frame.Navigate(new LoginPage(frame));

        }

    }
}