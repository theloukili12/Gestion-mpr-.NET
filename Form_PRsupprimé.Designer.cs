namespace Gestion_MPR
{
    partial class Form_PRsupprimé
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValide = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonAnnuler.Location = new System.Drawing.Point(517, 49);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(107, 31);
            this.buttonAnnuler.TabIndex = 12;
            this.buttonAnnuler.Text = "Anuuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValide
            // 
            this.buttonValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.buttonValide.Location = new System.Drawing.Point(517, 12);
            this.buttonValide.Name = "buttonValide";
            this.buttonValide.Size = new System.Drawing.Size(107, 31);
            this.buttonValide.TabIndex = 11;
            this.buttonValide.Text = "Validé";
            this.buttonValide.UseVisualStyleBackColor = true;
            this.buttonValide.Click += new System.EventHandler(this.buttonValide_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choisi La Pièce de Rechange  :";
            // 
            // comboBoxDes
            // 
            this.comboBoxDes.FormattingEnabled = true;
            this.comboBoxDes.Location = new System.Drawing.Point(293, 19);
            this.comboBoxDes.Name = "comboBoxDes";
            this.comboBoxDes.Size = new System.Drawing.Size(208, 24);
            this.comboBoxDes.TabIndex = 13;
            // 
            // Form_PRsupprimé
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 92);
            this.Controls.Add(this.comboBoxDes);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValide);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_PRsupprimé";
            this.Text = "Supprimer une Pièce de rechange";
            this.Load += new System.EventHandler(this.Form_PRsupprimé_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDes;
    }
}