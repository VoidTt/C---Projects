namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Color[] colors =
        {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Orange,
            Color.Purple,
            Color.Pink,
            Color.Brown,
            Color.Black,
            Color.Gray
        };

        int a = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.ForeColor = colors[a];
            a++;
            if (a >= colors.Length)
            {
                a = 0;
            }
        }
    }
}