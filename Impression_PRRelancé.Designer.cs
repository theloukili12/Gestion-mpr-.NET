namespace Gestion_MPR
{
    partial class Impression_PRRelancé
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impression_PRRelancé));
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRef = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxDefault = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataTable_PR_RelancéBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_impression_PR_Relancé = new Gestion_MPR.DataSet_impression_PR_Relancé();
            this.DataTable_PR_RelancéTableAdapter = new Gestion_MPR.DataSet_impression_PR_RelancéTableAdapters.DataTable_PR_RelancéTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_PR_RelancéBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_impression_PR_Relancé)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfficher.Location = new System.Drawing.Point(1049, 164);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(121, 41);
            this.buttonAfficher.TabIndex = 36;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(464, 163);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "et : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Date entre : ";
            // 
            // comboBoxRef
            // 
            this.comboBoxRef.FormattingEnabled = true;
            this.comboBoxRef.Location = new System.Drawing.Point(133, 67);
            this.comboBoxRef.Name = "comboBoxRef";
            this.comboBoxRef.Size = new System.Drawing.Size(126, 24);
            this.comboBoxRef.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Référence :";
            // 
            // comboBoxDes
            // 
            this.comboBoxDes.FormattingEnabled = true;
            this.comboBoxDes.Location = new System.Drawing.Point(502, 67);
            this.comboBoxDes.Name = "comboBoxDes";
            this.comboBoxDes.Size = new System.Drawing.Size(210, 24);
            this.comboBoxDes.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Désignation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Imprimer la liste des Pièces de rechange Relancé par MPR   :";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable_PR_RelancéBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestion_MPR.Report_Liste_PR_Relancé.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 233);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1153, 423);
            this.reportViewer1.TabIndex = 37;
            // 
            // comboBoxDefault
            // 
            this.comboBoxDefault.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxDefault.FormattingEnabled = true;
            this.comboBoxDefault.Items.AddRange(new object[] {
            "Emballage  -  PICO",
            "Emballage  -  Nion",
            "Emballage  -  Déformation",
            "Emballage  -  Rayor",
            "AEB  -  L\'écallage",
            "AEB  -  GRIN",
            "AEB  -  Dégradation de couleur",
            "AEB  -  Manque de CATA"});
            this.comboBoxDefault.Location = new System.Drawing.Point(105, 117);
            this.comboBoxDefault.Name = "comboBoxDefault";
            this.comboBoxDefault.Size = new System.Drawing.Size(215, 24);
            this.comboBoxDefault.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "Défault :";
            // 
            // DataTable_PR_RelancéBindingSource
            // 
            this.DataTable_PR_RelancéBindingSource.DataMember = "DataTable_PR_Relancé";
            this.DataTable_PR_RelancéBindingSource.DataSource = this.DataSet_impression_PR_Relancé;
            // 
            // DataSet_impression_PR_Relancé
            // 
            this.DataSet_impression_PR_Relancé.DataSetName = "DataSet_impression_PR_Relancé";
            this.DataSet_impression_PR_Relancé.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_PR_RelancéTableAdapter
            // 
            this.DataTable_PR_RelancéTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(902, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 40;
            this.button1.Text = "Vider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Impression_PRRelancé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxDefault);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxRef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Impression_PRRelancé";
            this.Text = "Impression de liste des PR Relancé";
            this.Load += new System.EventHandler(this.Impression_PRRelancé_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_PR_RelancéBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_impression_PR_Relancé)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource DataTable_PR_RelancéBindingSource;
        private DataSet_impression_PR_Relancé DataSet_impression_PR_Relancé;
        private DataSet_impression_PR_RelancéTableAdapters.DataTable_PR_RelancéTableAdapter DataTable_PR_RelancéTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBoxDefault;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}