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
    public partial class ReportByAll : Form
    {
        public ReportByAll()
        {
            InitializeComponent();
        }

        private void ReportByAll_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "post_databaseDataSet.ReportByAll". При необходимости она может быть перемещена или удалена.
            this.ReportByAllTableAdapter.Fill(this.post_databaseDataSet.ReportByAll);
            this.reportViewer1.RefreshReport();
        }
    }
}
