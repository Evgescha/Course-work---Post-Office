using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_work.Databases.PSU.Post_office.Variant_11
{
    public partial class Magazine : Form
    {
        public Magazine()
        {
            InitializeComponent();
        }

        private void Magazine_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Magazine_FormClosing(object sender, FormClosingEventArgs e)
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
                    газеты_и_журналыTableAdapter.Update(post_databaseDataSet.газеты_и_журналы);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void loadData()
        {
            this.газеты_и_журналыTableAdapter.Fill(this.post_databaseDataSet.газеты_и_журналы);
        }
    }
}
