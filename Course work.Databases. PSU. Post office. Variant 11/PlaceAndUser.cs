using System;
using System.Windows.Forms;

namespace Course_work.Databases.PSU.Post_office.Variant_11
{
    public partial class PlaceAndUser : Form
    {
        public PlaceAndUser()
        {
            InitializeComponent();
        }

        private void PlaceAndUser_Load(object sender, EventArgs e)
        {
          
            loadData();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void PlaceAndUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
          "Продолжить сохранение?",
          "Подтвердите сохранение",
          MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    участокTableAdapter.Update(post_databaseDataSet.участок);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void loadData()
        {  
            this.почтальоныTableAdapter.Fill(this.post_databaseDataSet.почтальоны);
            this.подписчикTableAdapter.Fill(this.post_databaseDataSet.подписчик);
            this.участокTableAdapter.Fill(this.post_databaseDataSet.участок);
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
          "Продолжить сохранение?",
          "Подтвердите сохранение",
          MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    подписчикTableAdapter.Update(post_databaseDataSet.подписчик);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
