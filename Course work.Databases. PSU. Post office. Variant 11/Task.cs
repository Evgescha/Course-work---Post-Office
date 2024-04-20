using System;
using System.Windows.Forms;

namespace Course_work.Databases.PSU.Post_office.Variant_11
{
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }

        private void Task_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void Task_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "post_databaseDataSet.газеты_и_журналы". При необходимости она может быть перемещена или удалена.
            this.газеты_и_журналыTableAdapter.Fill(this.post_databaseDataSet.газеты_и_журналы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "post_databaseDataSet4.Task8". При необходимости она может быть перемещена или удалена.
            this.task8TableAdapter.FillTask(this.post_databaseDataSet4.Task8);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "post_databaseDataSet4.Task7". При необходимости она может быть перемещена или удалена.
            this.task7TableAdapter.FillTask(this.post_databaseDataSet4.Task7);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "post_databaseDataSet.Task7". При необходимости она может быть перемещена или удалена.
            this.task7TableAdapter.FillTask(this.post_databaseDataSet.Task7);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "post_databaseDataSet3.Task6". При необходимости она может быть перемещена или удалена.
            this.task6TableAdapter.FillTask(this.post_databaseDataSet3.Task6);
            this.почтальоныTableAdapter.Fill(this.post_databaseDataSet1.почтальоны);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = task1BindingSource;            
            this.task1TableAdapter.FillTask(this.post_databaseDataSet.Task1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = task2BindingSource;
            this.task2TableAdapter.FillTask(this.post_databaseDataSet.Task2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = task3BindingSource;
            this.task3TableAdapter.FillTask(this.post_databaseDataSet.Task3, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) {
                MessageBox.Show("Не выбран почтальон из списка");
                return; 
            }
                        
            dataGridView1.DataSource = task4BindingSource;
            this.task4TableAdapter.FillTask(this.post_databaseDataSet.Task4, int.Parse(comboBox1.SelectedValue.ToString()));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 1 || textBox3.Text.Length < 1 || textBox4.Text.Length < 1 )
            {
                MessageBox.Show("Не заполнено одно из полей (фамилии, имени, отчества)");
                return;
            }

            dataGridView1.DataSource = task5BindingSource;
            this.task_5TableAdapter.FillTask(this.post_databaseDataSet.Task_5, $"%{textBox2.Text}%", $"%{textBox3.Text}%", $"%{textBox4.Text}%");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = task6BindingSource;
            this.task6TableAdapter.FillTask(this.post_databaseDataSet.Task6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = task7BindingSource;
            this.task7TableAdapter.FillTask(this.post_databaseDataSet.Task7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = task8BindingSource;
            this.task8TableAdapter.FillTask(this.post_databaseDataSet.Task8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Не выбрано издание из списка");
                return;
            }
            dataGridView1.DataSource = task9BindingSource;
            this.task9TableAdapter.FillTask(this.post_databaseDataSet.Task9, int.Parse(comboBox2.SelectedValue.ToString()));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Не выбрано издание из списка");
                return;
            }
            dataGridView1.DataSource = task10BindingSource;
            this.task10TableAdapter.FillTask(this.post_databaseDataSet.Task10, int.Parse(comboBox2.SelectedValue.ToString()));
        }
    }
}
