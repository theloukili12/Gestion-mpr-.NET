namespace Gestion_MPR
{
    partial class MAJ_Piece_Rechange_FLUX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAJ_Piece_Rechange_FLUX));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRef = new System.Windows.Forms.TextBox();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.textBoxLib = new System.Windows.Forms.TextBox();
            this.groupBoxMAJ = new System.Windows.Forms.GroupBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxMAJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(253)))));
            this.label2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 87);
            this.label2.TabIndex = 3;
            this.label2.Text = "Référence        :\r\nDésignation    :\r\nLibelle             :";
            // 
            // textBoxRef
            // 
            this.textBoxRef.Location = new System.Drawing.Point(182, 40);
            this.textBoxRef.Name = "textBoxRef";
            this.textBoxRef.Size = new System.Drawing.Size(127, 22);
            this.textBoxRef.TabIndex = 4;
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(182, 68);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(205, 22);
            this.textBoxDes.TabIndex = 5;
            // 
            // textBoxLib
            // 
            this.textBoxLib.Location = new System.Drawing.Point(182, 96);
            this.textBoxLib.Multiline = true;
            this.textBoxLib.Name = "textBoxLib";
            this.textBoxLib.Size = new System.Drawing.Size(205, 86);
            this.textBoxLib.TabIndex = 6;
            // 
            // groupBoxMAJ
            // 
            this.groupBoxMAJ.BackColor = System.Drawing.Color.White;
            this.groupBoxMAJ.Controls.Add(this.buttonSupprimer);
            this.groupBoxMAJ.Controls.Add(this.buttonAjouter);
            this.groupBoxMAJ.Controls.Add(this.buttonNouveau);
            this.groupBoxMAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.groupBoxMAJ.Location = new System.Drawing.Point(419, 7);
            this.groupBoxMAJ.Name = "groupBoxMAJ";
            this.groupBoxMAJ.Size = new System.Drawing.Size(172, 175);
            this.groupBoxMAJ.TabIndex = 7;
            this.groupBoxMAJ.TabStop = false;
            this.groupBoxMAJ.Text = "Mise à jour";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(16, 115);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(140, 40);
            this.buttonSupprimer.TabIndex = 2;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(16, 71);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(140, 40);
            this.buttonAjouter.TabIndex = 1;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Location = new System.Drawing.Point(16, 27);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(140, 40);
            this.buttonNouveau.TabIndex = 0;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 346);
            this.dataGridView1.TabIndex = 8;
            // 
            // MAJ_Piece_Rechange_FLUX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxMAJ);
            this.Controls.Add(this.textBoxLib);
            this.Controls.Add(this.textBoxDes);
            this.Controls.Add(this.textBoxRef);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "MAJ_Piece_Rechange_FLUX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mise à jour les Pièces de rechange";
            this.Activated += new System.EventHandler(this.MAJ_Piece_Rechange_Activated_1);
            this.Load += new System.EventHandler(this.MAJ_Piece_Rechange_Load);
            this.groupBoxMAJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRef;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.TextBox textBoxLib;
        private System.Windows.Forms.GroupBox groupBoxMAJ;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}