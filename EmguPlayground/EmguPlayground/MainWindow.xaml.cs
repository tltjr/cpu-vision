using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguPlayground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image1_Initialized(object sender, EventArgs e)
        {
            //var image = new Image<Bgr, byte>("Address_Position.jpg");
            var image = new Image<Bgr, byte>("address-position-bg-remove.png");

            Image<Gray, Byte> cannyFrame = image.Canny(500, 250);

            Image1.Source = BitmapSourceConvert.ToBitmapSource(cannyFrame);
        }

    }
}
