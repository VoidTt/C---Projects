using Microsoft.VisualBasic.Devices;
using System.Numerics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        int player = 0;
        int enemy = 0;

        public Form1()
        {
            InitializeComponent();
            enemy = rand.Next(15, 22);

            label1.Text = "Ваши очки: 0";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int card = rand.Next(1, 12);
            player += card;
            label1.Text = "Ваши очки: " + player;

            if (player > 21)
                label2.Text = "Перебор, Вы проиграли";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player > 21)
            {
                label2.Text = "Вы проиграли";
            }
            else if (player > enemy)
            {
                label2.Text = "Вы выиграли, Враг: " + enemy;
            }
            else if (player < enemy)
            {
                label2.Text = "Вы проиграли, Враг: " + enemy;
            }
            else
            {
                label2.Text = "Ничья, Враг: " + enemy;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player = 0;
            enemy = rand.Next(15, 22);

            label1.Text = "Ваши очки: 0";
            label2.Text = "";
        }
    }
}
