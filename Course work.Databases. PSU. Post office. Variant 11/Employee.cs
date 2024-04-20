using System;
using System.Windows.Forms;

namespace Course_work.Databases.PSU.Post_office.Variant_11
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {         
            loadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
             "Продолжить сохранение?",
             "Подтвердите сохранение",
             MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    почтальоныTableAdapter.Update(post_databaseDataSet.почтальоны);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void loadData()
        {
            this.участокTableAdapter.Fill(this.post_databaseDataSet.участок);
            this.почтальоныTableAdapter.Fill(this.post_databaseDataSet.почтальоны);
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
