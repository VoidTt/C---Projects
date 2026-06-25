namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            trackBar1.Minimum = 50;
            trackBar1.Maximum = 300;
            trackBar1.Value = 100;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Width = trackBar1.Value;
            pictureBox1.Height = trackBar1.Value;
        }
    }
}
