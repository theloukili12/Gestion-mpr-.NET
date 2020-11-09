namespace Gestion_MPR
{
    partial class Impression_PRFabriqué
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impression_PRFabriqué));
            this.DataTable_PRFabriquéBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Impression = new Gestion_MPR.DataSet_Impression();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDes = new System.Windows.Forms.ComboBox();
            this.comboBoxRef = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSemaine = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.DataTable_PRFabriquéTableAdapter = new Gestion_MPR.DataSet_ImpressionTableAdapters.DataTable_PRFabriquéTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_PRFabriquéBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Impression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemaine)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_PRFabriquéBindingSource
            // 
            this.DataTable_PRFabriquéBindingSource.DataMember = "DataTable_PRFabriqué";
            this.DataTable_PRFabriquéBindingSource.DataSource = this.DataSet_Impression;
            // 
            // DataSet_Impression
            // 
            this.DataSet_Impression.DataSetName = "DataSet_Impression";
            this.DataSet_Impression.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable_PRFabriquéBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestion_MPR.Report_test.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 210);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1158, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Imprimer la liste des Pièces de rechange fabriqué par FLUX   :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Désignation :";
            // 
            // comboBoxDes
            // 
            this.comboBoxDes.FormattingEnabled = true;
            this.comboBoxDes.Location = new System.Drawing.Point(502, 67);
            this.comboBoxDes.Name = "comboBoxDes";
            this.comboBoxDes.Size = new System.Drawing.Size(210, 24);
            this.comboBoxDes.TabIndex = 15;
            // 
            // comboBoxRef
            // 
            this.comboBoxRef.FormattingEnabled = true;
            this.comboBoxRef.Location = new System.Drawing.Point(133, 67);
            this.comboBoxRef.Name = "comboBoxRef";
            this.comboBoxRef.Size = new System.Drawing.Size(126, 24);
            this.comboBoxRef.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Référence :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Semaine :";
            // 
            // numericUpDownSemaine
            // 
            this.numericUpDownSemaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSemaine.Location = new System.Drawing.Point(133, 110);
            this.numericUpDownSemaine.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.numericUpDownSemaine.Name = "numericUpDownSemaine";
            this.numericUpDownSemaine.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownSemaine.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date entre : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "et : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(464, 163);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficher.Location = new System.Drawing.Point(1049, 164);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(121, 41);
            this.buttonAfficher.TabIndex = 24;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // DataTable_PRFabriquéTableAdapter
            // 
            this.DataTable_PRFabriquéTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(901, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 41;
            this.button1.Text = "Vider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Impression_PRFabriqué
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownSemaine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Impression_PRFabriqué";
            this.Text = "Impression de liste de PR Fabriqué par FLUX";
            this.Load += new System.EventHandler(this.Impression_PRFabriqué_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_PRFabriquéBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Impression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemaine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDes;
        private System.Windows.Forms.ComboBox comboBoxRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSemaine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.BindingSource DataTable_PRFabriquéBindingSource;
        private DataSet_Impression DataSet_Impression;
        private DataSet_ImpressionTableAdapters.DataTable_PRFabriquéTableAdapter DataTable_PRFabriquéTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}