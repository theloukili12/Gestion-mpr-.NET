namespace Gestion_MPR
{
    partial class Form_SaisiPRFab_FLUX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SaisiPRFab_FLUX));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownEmb = new System.Windows.Forms.NumericUpDown();
            this.radioButtonOui = new System.Windows.Forms.RadioButton();
            this.radioButtonNon = new System.Windows.Forms.RadioButton();
            this.comboBoxRef = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDes = new System.Windows.Forms.ComboBox();
            this.labelQteRelancé = new System.Windows.Forms.Label();
            this.numericUpDownSemaine = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRelance = new System.Windows.Forms.NumericUpDown();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownFab = new System.Windows.Forms.NumericUpDown();
            this.labelQteFabriqué = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemaine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRelance)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFab)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(253)))));
            this.label2.Font = new System.Drawing.Font("Sitka Display", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saisir une pièce fabriqué :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(253)))));
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 203);
            this.label1.TabIndex = 4;
            this.label1.Text = "Capacité d\'emballage   :\r\n\r\nRelance                          :\r\n\r\nSemaine de beso" +
    "in        :\r\n\r\nRéférence                       :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownEmb
            // 
            this.numericUpDownEmb.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownEmb.Location = new System.Drawing.Point(297, 99);
            this.numericUpDownEmb.Name = "numericUpDownEmb";
            this.numericUpDownEmb.Size = new System.Drawing.Size(86, 33);
            this.numericUpDownEmb.TabIndex = 5;
            // 
            // radioButtonOui
            // 
            this.radioButtonOui.AutoSize = true;
            this.radioButtonOui.BackColor = System.Drawing.Color.White;
            this.radioButtonOui.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonOui.Location = new System.Drawing.Point(297, 156);
            this.radioButtonOui.Name = "radioButtonOui";
            this.radioButtonOui.Size = new System.Drawing.Size(64, 33);
            this.radioButtonOui.TabIndex = 6;
            this.radioButtonOui.TabStop = true;
            this.radioButtonOui.Text = "Oui";
            this.radioButtonOui.UseVisualStyleBackColor = false;
            this.radioButtonOui.CheckedChanged += new System.EventHandler(this.radioButtonOui_CheckedChanged);
            // 
            // radioButtonNon
            // 
            this.radioButtonNon.AutoSize = true;
            this.radioButtonNon.BackColor = System.Drawing.Color.White;
            this.radioButtonNon.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonNon.Location = new System.Drawing.Point(409, 156);
            this.radioButtonNon.Name = "radioButtonNon";
            this.radioButtonNon.Size = new System.Drawing.Size(69, 33);
            this.radioButtonNon.TabIndex = 7;
            this.radioButtonNon.TabStop = true;
            this.radioButtonNon.Text = "Non";
            this.radioButtonNon.UseVisualStyleBackColor = false;
            this.radioButtonNon.CheckedChanged += new System.EventHandler(this.radioButtonNon_CheckedChanged);
            // 
            // comboBoxRef
            // 
            this.comboBoxRef.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxRef.FormattingEnabled = true;
            this.comboBoxRef.Location = new System.Drawing.Point(297, 276);
            this.comboBoxRef.Name = "comboBoxRef";
            this.comboBoxRef.Size = new System.Drawing.Size(181, 32);
            this.comboBoxRef.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(253)))));
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Désignation  :";
            // 
            // comboBoxDes
            // 
            this.comboBoxDes.Font = new System.Drawing.Font("Sitka Display", 10F, System.Drawing.FontStyle.Bold);
            this.comboBoxDes.FormattingEnabled = true;
            this.comboBoxDes.Location = new System.Drawing.Point(705, 276);
            this.comboBoxDes.Name = "comboBoxDes";
            this.comboBoxDes.Size = new System.Drawing.Size(237, 32);
            this.comboBoxDes.TabIndex = 11;
            // 
            // labelQteRelancé
            // 
            this.labelQteRelancé.AutoSize = true;
            this.labelQteRelancé.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(253)))));
            this.labelQteRelancé.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQteRelancé.Location = new System.Drawing.Point(535, 158);
            this.labelQteRelancé.Name = "labelQteRelancé";
            this.labelQteRelancé.Size = new System.Drawing.Size(168, 29);
            this.labelQteRelancé.TabIndex = 12;
            this.labelQteRelancé.Text = "Quantité Relancé :";
            this.labelQteRelancé.Visible = false;
            // 
            // numericUpDownSemaine
            // 
            this.numericUpDownSemaine.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownSemaine.Location = new System.Drawing.Point(297, 214);
            this.numericUpDownSemaine.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.numericUpDownSemaine.Name = "numericUpDownSemaine";
            this.numericUpDownSemaine.Size = new System.Drawing.Size(86, 33);
            this.numericUpDownSemaine.TabIndex = 8;
            // 
            // numericUpDownRelance
            // 
            this.numericUpDownRelance.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownRelance.Location = new System.Drawing.Point(732, 156);
            this.numericUpDownRelance.Name = "numericUpDownRelance";
            this.numericUpDownRelance.Size = new System.Drawing.Size(86, 33);
            this.numericUpDownRelance.TabIndex = 13;
            this.numericUpDownRelance.Visible = false;
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouveau.Location = new System.Drawing.Point(878, 343);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(160, 53);
            this.buttonNouveau.TabIndex = 14;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(878, 461);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(160, 53);
            this.buttonAnnuler.TabIndex = 16;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregistrer.Location = new System.Drawing.Point(878, 402);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(160, 53);
            this.buttonEnregistrer.TabIndex = 15;
            this.buttonEnregistrer.Text = "Enregistré";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(54, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 101);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remarque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "• Le date est enregistré automatiquement par le system\r\n\r\n";
            // 
            // numericUpDownFab
            // 
            this.numericUpDownFab.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold);
            this.numericUpDownFab.Location = new System.Drawing.Point(297, 329);
            this.numericUpDownFab.Name = "numericUpDownFab";
            this.numericUpDownFab.Size = new System.Drawing.Size(86, 33);
            this.numericUpDownFab.TabIndex = 19;
            this.numericUpDownFab.Visible = false;
            // 
            // labelQteFabriqué
            // 
            this.labelQteFabriqué.AutoSize = true;
            this.labelQteFabriqué.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(253)))));
            this.labelQteFabriqué.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQteFabriqué.Location = new System.Drawing.Point(49, 329);
            this.labelQteFabriqué.Name = "labelQteFabriqué";
            this.labelQteFabriqué.Size = new System.Drawing.Size(214, 29);
            this.labelQteFabriqué.TabIndex = 20;
            this.labelQteFabriqué.Text = "Quantité fabriqué         :";
            this.labelQteFabriqué.Visible = false;
            // 
            // Form_SaisiPRFab_FLUX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.labelQteFabriqué);
            this.Controls.Add(this.numericUpDownFab);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.numericUpDownRelance);
            this.Controls.Add(this.labelQteRelancé);
            this.Controls.Add(this.comboBoxDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRef);
            this.Controls.Add(this.numericUpDownSemaine);
            this.Controls.Add(this.radioButtonNon);
            this.Controls.Add(this.radioButtonOui);
            this.Controls.Add(this.numericUpDownEmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Form_SaisiPRFab_FLUX";
            this.Text = "Saisir un Pièce de rechange à Relancer";
            this.Load += new System.EventHandler(this.Form_SaisiPRFab_FLUX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSemaine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRelance)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownEmb;
        private System.Windows.Forms.RadioButton radioButtonOui;
        private System.Windows.Forms.RadioButton radioButtonNon;
        private System.Windows.Forms.ComboBox comboBoxRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDes;
        private System.Windows.Forms.Label labelQteRelancé;
        private System.Windows.Forms.NumericUpDown numericUpDownSemaine;
        private System.Windows.Forms.NumericUpDown numericUpDownRelance;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownFab;
        private System.Windows.Forms.Label labelQteFabriqué;
    }
}