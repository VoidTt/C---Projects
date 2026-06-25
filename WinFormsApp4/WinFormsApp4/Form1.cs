namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;

            listView1.Columns.Add("Имя", 100);
            listView1.Columns.Add("Возраст", 100);
            listView1.Columns.Add("Город", 100);

            listView1.Items.Add(new ListViewItem(new string[] { "Иван", "18", "Москва" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Анна", "20", "Казань" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Петр", "19", "Сочи" }));

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                label1.Text = item.SubItems[0].Text;
                label2.Text = item.SubItems[1].Text;
                label3.Text = item.SubItems[2].Text;

                listView1.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Выберите строку!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
