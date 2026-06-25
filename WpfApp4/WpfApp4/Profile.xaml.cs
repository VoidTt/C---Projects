using System.Configuration;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    public partial class ProfilePage : Page
    {
        Frame frame;

        public ProfilePage(Frame f)
        {
            InitializeComponent();
            frame = f;
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new SettingsPage(frame));
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new OrdersPage(frame));
        }
    }
}