using System;
using System.Windows.Forms;

namespace Course_work.Databases.PSU.Post_office.Variant_11
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    подпискиTableAdapter.Update(post_databaseDataSet.подписки);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void loadData()
        {
            this.подписчикФИОTableAdapter.FillFIO(this.post_databaseDataSet.подписчикФИО);
            this.газеты_и_журналыTableAdapter.Fill(this.post_databaseDataSet.газеты_и_журналы);
            this.подпискиTableAdapter.Fill(this.post_databaseDataSet.подписки);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ReportView().Show();
        }
    }
}
