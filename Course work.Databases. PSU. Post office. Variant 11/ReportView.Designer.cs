
namespace Course_work.Databases.PSU.Post_office.Variant_11
{
    partial class ReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportWithOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.post_databaseDataSet = new Course_work.Databases.PSU.Post_office.Variant_11.post_databaseDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportWithOrderTableAdapter = new Course_work.Databases.PSU.Post_office.Variant_11.post_databaseDataSetTableAdapters.ReportWithOrderTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.подписчикФИОBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.подписчикФИОTableAdapter = new Course_work.Databases.PSU.Post_office.Variant_11.post_databaseDataSetTableAdapters.подписчикФИОTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportWithOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подписчикФИОBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportWithOrderBindingSource
            // 
            this.ReportWithOrderBindingSource.DataMember = "ReportWithOrder";
            this.ReportWithOrderBindingSource.DataSource = this.post_databaseDataSet;
            // 
            // post_databaseDataSet
            // 
            this.post_databaseDataSet.DataSetName = "post_databaseDataSet";
            this.post_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ReportWithOrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Course_work.Databases.PSU.Post_office.Variant_11.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 401);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportWithOrderTableAdapter
            // 
            this.ReportWithOrderTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите подписчика";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.подписчикФИОBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Код";
            // 
            // подписчикФИОBindingSource
            // 
            this.подписчикФИОBindingSource.DataMember = "подписчикФИО";
            this.подписчикФИОBindingSource.DataSource = this.post_databaseDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите дату";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(476, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
            // 
            // подписчикФИОTableAdapter
            // 
            this.подписчикФИОTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Квитанция за дату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportView";
            this.Text = "Квитанции по подпискам";
            this.Load += new System.EventHandler(this.ReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportWithOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подписчикФИОBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportWithOrderBindingSource;
        private post_databaseDataSet post_databaseDataSet;
        private post_databaseDataSetTableAdapters.ReportWithOrderTableAdapter ReportWithOrderTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource подписчикФИОBindingSource;
        private post_databaseDataSetTableAdapters.подписчикФИОTableAdapter подписчикФИОTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}