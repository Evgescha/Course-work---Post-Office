using System;
using System.Windows.Forms;

namespace Course_work.Databases.PSU.Post_office.Variant_11
{
    public partial class Main : Form
    {
        public static Main main;
        public Main()
        {
            InitializeComponent();
            main = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Magazine().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Employee().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new PlaceAndUser().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Task().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new ReportByAll().Show();
        }
    }
}
