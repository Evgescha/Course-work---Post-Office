
namespace Course_work.Databases.PSU.Post_office.Variant_11
{
    partial class ReportByAll
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.post_databaseDataSet = new Course_work.Databases.PSU.Post_office.Variant_11.post_databaseDataSet();
            this.ReportByAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportByAllTableAdapter = new Course_work.Databases.PSU.Post_office.Variant_11.post_databaseDataSetTableAdapters.ReportByAllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.post_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportByAllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReportByAllBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Course_work.Databases.PSU.Post_office.Variant_11.ReportByAll.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // post_databaseDataSet
            // 
            this.post_databaseDataSet.DataSetName = "post_databaseDataSet";
            this.post_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportByAllBindingSource
            // 
            this.ReportByAllBindingSource.DataMember = "ReportByAll";
            this.ReportByAllBindingSource.DataSource = this.post_databaseDataSet;
            // 
            // ReportByAllTableAdapter
            // 
            this.ReportByAllTableAdapter.ClearBeforeFill = true;
            // 
            // ReportByAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportByAll";
            this.Text = "Отчет о доставке";
            this.Load += new System.EventHandler(this.ReportByAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.post_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportByAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private post_databaseDataSet post_databaseDataSet;
        private System.Windows.Forms.BindingSource ReportByAllBindingSource;
        private post_databaseDataSetTableAdapters.ReportByAllTableAdapter ReportByAllTableAdapter;
    }
}