namespace Gestion_MPR
{
    partial class FormAuthentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthentification));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPilote = new System.Windows.Forms.TextBox();
            this.textBoxPS = new System.Windows.Forms.TextBox();
            this.buttonConnecte = new System.Windows.Forms.Button();
            this.buttonAnuuler = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poste                   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de Pilote    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe      :";
            // 
            // textBoxPilote
            // 
            this.textBoxPilote.Location = new System.Drawing.Point(297, 65);
            this.textBoxPilote.Name = "textBoxPilote";
            this.textBoxPilote.Size = new System.Drawing.Size(181, 23);
            this.textBoxPilote.TabIndex = 2;
            // 
            // textBoxPS
            // 
            this.textBoxPS.Location = new System.Drawing.Point(297, 93);
            this.textBoxPS.Name = "textBoxPS";
            this.textBoxPS.PasswordChar = '•';
            this.textBoxPS.Size = new System.Drawing.Size(181, 23);
            this.textBoxPS.TabIndex = 3;
            // 
            // buttonConnecte
            // 
            this.buttonConnecte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnecte.Location = new System.Drawing.Point(156, 254);
            this.buttonConnecte.Name = "buttonConnecte";
            this.buttonConnecte.Size = new System.Drawing.Size(114, 48);
            this.buttonConnecte.TabIndex = 4;
            this.buttonConnecte.Text = "Validé";
            this.buttonConnecte.UseVisualStyleBackColor = true;
            this.buttonConnecte.Click += new System.EventHandler(this.buttonConnecte_Click);
            // 
            // buttonAnuuler
            // 
            this.buttonAnuuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnuuler.Location = new System.Drawing.Point(297, 254);
            this.buttonAnuuler.Name = "buttonAnuuler";
            this.buttonAnuuler.Size = new System.Drawing.Size(114, 48);
            this.buttonAnuuler.TabIndex = 5;
            this.buttonAnuuler.Text = "Annuler";
            this.buttonAnuuler.UseVisualStyleBackColor = true;
            this.buttonAnuuler.Click += new System.EventHandler(this.buttonAnuuler_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "FLUX",
            "MPR",
            "ADMIN"});
            this.listBox1.Location = new System.Drawing.Point(297, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 36);
            this.listBox1.TabIndex = 1;
            // 
            // FormAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 343);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAnuuler);
            this.Controls.Add(this.buttonConnecte);
            this.Controls.Add(this.textBoxPS);
            this.Controls.Add(this.textBoxPilote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "FormAuthentification";
            this.Text = "Authentification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuthentification_FormClosed);
            this.Load += new System.EventHandler(this.FormAuthentification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPilote;
        private System.Windows.Forms.TextBox textBoxPS;
        private System.Windows.Forms.Button buttonConnecte;
        private System.Windows.Forms.Button buttonAnuuler;
        private System.Windows.Forms.ListBox listBox1;
    }
}

