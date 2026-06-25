using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp2
{
    public class MyImage : FrameworkElement
    {
        private BitmapImage image;

        public MyImage()
        {
            image = new BitmapImage(
                new Uri("cat.jpg", UriKind.Relative));
        }

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);

            dc.DrawImage(image, new Rect(100, 100, 300, 200));
        }
    }
}