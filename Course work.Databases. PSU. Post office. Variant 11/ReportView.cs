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
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            this.подписчикФИОTableAdapter.FillFIO(this.post_databaseDataSet.подписчикФИО);
            dateTimePicker1.Value = DateTime.Today;
            Console.WriteLine(dateTimePicker1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) { MessageBox.Show("Не выбран подписчик"); return; }

            this.ReportWithOrderTableAdapter.Fill(this.post_databaseDataSet.ReportWithOrder, int.Parse(comboBox1.SelectedValue.ToString()),dateTimePicker1.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
