using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            public MainWindow()
            {
                InitializeComponent();
            }

        private void canvas1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(canvas1);

            Rectangle newRect = new Rectangle();

            newRect.Width = rect.Width;
            newRect.Height = rect.Height;
            newRect.Fill = rect.Fill;

            Canvas.SetLeft(newRect, point.X);
            Canvas.SetTop(newRect, point.Y);

            canvas1.Children.Add(newRect);
        }
    }
}