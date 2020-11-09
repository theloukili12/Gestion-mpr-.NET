namespace Gestion_MPR
{
    partial class Impression_Liste_Pr_Relancées
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impression_Liste_Pr_Relancées));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRef = new System.Windows.Forms.ComboBox();
            this.comboBoxDes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.DataTable_ListePr_RelancéesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Impression_PR_fabRel = new Gestion_MPR.DataSet_Impression_PR_fabRel();
            this.DataTable_ListePr_RelancéesTableAdapter = new Gestion_MPR.DataSet_Impression_PR_fabRelTableAdapters.DataTable_ListePr_RelancéesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_ListePr_RelancéesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Impression_PR_fabRel)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable_ListePr_RelancéesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestion_MPR.Report_Liste_PR_Relancées.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 173);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1153, 412);
            this.reportViewer1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Imprimer la liste des Pièces de rechange Relancées (fabriqué)  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Référence :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "Désignation :";
            // 
            // comboBoxRef
            // 
            this.comboBoxRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.comboBoxRef.FormattingEnabled = true;
            this.comboBoxRef.Location = new System.Drawing.Point(162, 64);
            this.comboBoxRef.Name = "comboBoxRef";
            this.comboBoxRef.Size = new System.Drawing.Size(147, 26);
            this.comboBoxRef.TabIndex = 42;
            // 
            // comboBoxDes
            // 
            this.comboBoxDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.comboBoxDes.FormattingEnabled = true;
            this.comboBoxDes.Location = new System.Drawing.Point(539, 62);
            this.comboBoxDes.Name = "comboBoxDes";
            this.comboBoxDes.Size = new System.Drawing.Size(228, 26);
            this.comboBoxDes.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Date de validation entre :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(261, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 22);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Et :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(605, 109);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(186, 22);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(897, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 47;
            this.button1.Text = "Vider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficher.Location = new System.Drawing.Point(1044, 109);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(121, 41);
            this.buttonAfficher.TabIndex = 46;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // DataTable_ListePr_RelancéesBindingSource
            // 
            this.DataTable_ListePr_RelancéesBindingSource.DataMember = "DataTable_ListePr_Relancées";
            this.DataTable_ListePr_RelancéesBindingSource.DataSource = this.DataSet_Impression_PR_fabRel;
            // 
            // DataSet_Impression_PR_fabRel
            // 
            this.DataSet_Impression_PR_fabRel.DataSetName = "DataSet_Impression_PR_fabRel";
            this.DataSet_Impression_PR_fabRel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_ListePr_RelancéesTableAdapter
            // 
            this.DataTable_ListePr_RelancéesTableAdapter.ClearBeforeFill = true;
            // 
            // Impression_Liste_Pr_Relancées
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxDes);
            this.Controls.Add(this.comboBoxRef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Impression_Liste_Pr_Relancées";
            this.Text = "Impression de liste des Pièces de rechange Relancées";
            this.Load += new System.EventHandler(this.Impression_Liste_Pr_Relancées_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_ListePr_RelancéesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Impression_PR_fabRel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable_ListePr_RelancéesBindingSource;
        private DataSet_Impression_PR_fabRel DataSet_Impression_PR_fabRel;
        private DataSet_Impression_PR_fabRelTableAdapters.DataTable_ListePr_RelancéesTableAdapter DataTable_ListePr_RelancéesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRef;
        private System.Windows.Forms.ComboBox comboBoxDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAfficher;
    }
}