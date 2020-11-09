namespace Gestion_MPR
{
    partial class Testttt
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
            this.DataSet_Impression = new Gestion_MPR.DataSet_Impression();
            this.DataTable_PRFabriquéBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable_PRFabriquéTableAdapter = new Gestion_MPR.DataSet_ImpressionTableAdapters.DataTable_PRFabriquéTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Impression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_PRFabriquéBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable_PRFabriquéBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestion_MPR.Report_Histogramme_PR_Fabriqué.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(697, 416);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_Impression
            // 
            this.DataSet_Impression.DataSetName = "DataSet_Impression";
            this.DataSet_Impression.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_PRFabriquéBindingSource
            // 
            this.DataTable_PRFabriquéBindingSource.DataMember = "DataTable_PRFabriqué";
            this.DataTable_PRFabriquéBindingSource.DataSource = this.DataSet_Impression;
            // 
            // DataTable_PRFabriquéTableAdapter
            // 
            this.DataTable_PRFabriquéTableAdapter.ClearBeforeFill = true;
            // 
            // Testttt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 416);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Testttt";
            this.Text = "Testttt";
            this.Load += new System.EventHandler(this.Testttt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Impression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_PRFabriquéBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable_PRFabriquéBindingSource;
        private DataSet_Impression DataSet_Impression;
        private DataSet_ImpressionTableAdapters.DataTable_PRFabriquéTableAdapter DataTable_PRFabriquéTableAdapter;
    }
}