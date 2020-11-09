namespace Gestion_MPR
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listePièceRechangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRFabriquéParFLUXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRRelancéParMPRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRFabriquéPourRelanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suivrePRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lancéUnePRFabriquéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validéPRRelancéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.décalageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relancePRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesPièceRelancéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerListeDesPRRelancéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPilotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelDeco = new System.Windows.Forms.LinkLabel();
            this.labelPilote = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listePièceRechangeToolStripMenuItem,
            this.suivrePRToolStripMenuItem,
            this.décalageToolStripMenuItem,
            this.gestionDePRToolStripMenuItem,
            this.impressionToolStripMenuItem,
            this.gestionDesPilotesToolStripMenuItem,
            this.graphToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1131, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listePièceRechangeToolStripMenuItem
            // 
            this.listePièceRechangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRFabriquéParFLUXToolStripMenuItem,
            this.pRRelancéParMPRToolStripMenuItem,
            this.pRFabriquéPourRelanceToolStripMenuItem});
            this.listePièceRechangeToolStripMenuItem.Name = "listePièceRechangeToolStripMenuItem";
            this.listePièceRechangeToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.listePièceRechangeToolStripMenuItem.Text = "Suivi";
            // 
            // pRFabriquéParFLUXToolStripMenuItem
            // 
            this.pRFabriquéParFLUXToolStripMenuItem.Name = "pRFabriquéParFLUXToolStripMenuItem";
            this.pRFabriquéParFLUXToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.pRFabriquéParFLUXToolStripMenuItem.Text = "PR fabriqué par FLUX";
            this.pRFabriquéParFLUXToolStripMenuItem.Click += new System.EventHandler(this.pRFabriquéParFLUXToolStripMenuItem_Click);
            // 
            // pRRelancéParMPRToolStripMenuItem
            // 
            this.pRRelancéParMPRToolStripMenuItem.Name = "pRRelancéParMPRToolStripMenuItem";
            this.pRRelancéParMPRToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.pRRelancéParMPRToolStripMenuItem.Text = "Relance saisi par MPR";
            this.pRRelancéParMPRToolStripMenuItem.Click += new System.EventHandler(this.pRRelancéParMPRToolStripMenuItem_Click);
            // 
            // pRFabriquéPourRelanceToolStripMenuItem
            // 
            this.pRFabriquéPourRelanceToolStripMenuItem.Name = "pRFabriquéPourRelanceToolStripMenuItem";
            this.pRFabriquéPourRelanceToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.pRFabriquéPourRelanceToolStripMenuItem.Text = "PR Relancées";
            this.pRFabriquéPourRelanceToolStripMenuItem.Click += new System.EventHandler(this.pRFabriquéPourRelanceToolStripMenuItem_Click);
            // 
            // suivrePRToolStripMenuItem
            // 
            this.suivrePRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lancéUnePRFabriquéToolStripMenuItem,
            this.validéPRRelancéToolStripMenuItem});
            this.suivrePRToolStripMenuItem.Name = "suivrePRToolStripMenuItem";
            this.suivrePRToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.suivrePRToolStripMenuItem.Text = "Lancé/Validé PR";
            // 
            // lancéUnePRFabriquéToolStripMenuItem
            // 
            this.lancéUnePRFabriquéToolStripMenuItem.Name = "lancéUnePRFabriquéToolStripMenuItem";
            this.lancéUnePRFabriquéToolStripMenuItem.Size = new System.Drawing.Size(301, 30);
            this.lancéUnePRFabriquéToolStripMenuItem.Text = "Saisir des PR fabriquées";
            this.lancéUnePRFabriquéToolStripMenuItem.Click += new System.EventHandler(this.lancéUnePRFabriquéToolStripMenuItem_Click);
            // 
            // validéPRRelancéToolStripMenuItem
            // 
            this.validéPRRelancéToolStripMenuItem.Name = "validéPRRelancéToolStripMenuItem";
            this.validéPRRelancéToolStripMenuItem.Size = new System.Drawing.Size(301, 30);
            this.validéPRRelancéToolStripMenuItem.Text = "Valider des PR Relancées";
            this.validéPRRelancéToolStripMenuItem.Click += new System.EventHandler(this.validéPRRelancéToolStripMenuItem_Click);
            // 
            // décalageToolStripMenuItem
            // 
            this.décalageToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.décalageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relancePRToolStripMenuItem});
            this.décalageToolStripMenuItem.Name = "décalageToolStripMenuItem";
            this.décalageToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.décalageToolStripMenuItem.Text = "Décalage";
            // 
            // relancePRToolStripMenuItem
            // 
            this.relancePRToolStripMenuItem.Name = "relancePRToolStripMenuItem";
            this.relancePRToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.relancePRToolStripMenuItem.Text = "Saisir des PR à relancer";
            this.relancePRToolStripMenuItem.Click += new System.EventHandler(this.relancePRToolStripMenuItem_Click);
            // 
            // gestionDePRToolStripMenuItem
            // 
            this.gestionDePRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem});
            this.gestionDePRToolStripMenuItem.Name = "gestionDePRToolStripMenuItem";
            this.gestionDePRToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.gestionDePRToolStripMenuItem.Text = "Gestion des PR";
            // 
            // miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem
            // 
            this.miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem.Name = "miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem";
            this.miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem.Size = new System.Drawing.Size(621, 30);
            this.miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem.Text = "Mise à jour :Piece de rechange (Ajouter, Modifier,Supprimer)";
            this.miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem_Click);
            // 
            // impressionToolStripMenuItem
            // 
            this.impressionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesPièceRelancéToolStripMenuItem,
            this.listeToolStripMenuItem,
            this.imprimerListeDesPRRelancéesToolStripMenuItem});
            this.impressionToolStripMenuItem.Name = "impressionToolStripMenuItem";
            this.impressionToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.impressionToolStripMenuItem.Text = "Impression";
            // 
            // listeDesPièceRelancéToolStripMenuItem
            // 
            this.listeDesPièceRelancéToolStripMenuItem.Name = "listeDesPièceRelancéToolStripMenuItem";
            this.listeDesPièceRelancéToolStripMenuItem.Size = new System.Drawing.Size(381, 30);
            this.listeDesPièceRelancéToolStripMenuItem.Text = "Imprimer : Liste des Pièce Relancé";
            this.listeDesPièceRelancéToolStripMenuItem.Click += new System.EventHandler(this.listeDesPièceRelancéToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(381, 30);
            this.listeToolStripMenuItem.Text = "Imprimer : Liste des PR fabriqué ";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // imprimerListeDesPRRelancéesToolStripMenuItem
            // 
            this.imprimerListeDesPRRelancéesToolStripMenuItem.Name = "imprimerListeDesPRRelancéesToolStripMenuItem";
            this.imprimerListeDesPRRelancéesToolStripMenuItem.Size = new System.Drawing.Size(381, 30);
            this.imprimerListeDesPRRelancéesToolStripMenuItem.Text = "Imprimer : Liste des PR relancées";
            // 
            // gestionDesPilotesToolStripMenuItem
            // 
            this.gestionDesPilotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseÀJourToolStripMenuItem});
            this.gestionDesPilotesToolStripMenuItem.Name = "gestionDesPilotesToolStripMenuItem";
            this.gestionDesPilotesToolStripMenuItem.Size = new System.Drawing.Size(191, 29);
            this.gestionDesPilotesToolStripMenuItem.Text = "Gestion des Pilotes";
            // 
            // miseÀJourToolStripMenuItem
            // 
            this.miseÀJourToolStripMenuItem.Name = "miseÀJourToolStripMenuItem";
            this.miseÀJourToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.miseÀJourToolStripMenuItem.Text = "Mise à jour";
            this.miseÀJourToolStripMenuItem.Click += new System.EventHandler(this.miseÀJourToolStripMenuItem_Click_1);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.BackgroundImage")));
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(253)))));
            this.label2.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 147);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gestion \r\nde Magazine des pièces \r\nde rechange";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelDeco
            // 
            this.linkLabelDeco.AutoSize = true;
            this.linkLabelDeco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(253)))));
            this.linkLabelDeco.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelDeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDeco.Location = new System.Drawing.Point(0, 33);
            this.linkLabelDeco.Name = "linkLabelDeco";
            this.linkLabelDeco.Size = new System.Drawing.Size(127, 25);
            this.linkLabelDeco.TabIndex = 3;
            this.linkLabelDeco.TabStop = true;
            this.linkLabelDeco.Text = "Déconnexion";
            this.linkLabelDeco.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDeco_LinkClicked);
            // 
            // labelPilote
            // 
            this.labelPilote.AutoSize = true;
            this.labelPilote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(253)))));
            this.labelPilote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelPilote.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPilote.Location = new System.Drawing.Point(0, 526);
            this.labelPilote.Name = "labelPilote";
            this.labelPilote.Size = new System.Drawing.Size(108, 29);
            this.labelPilote.TabIndex = 4;
            this.labelPilote.Text = "LabelPilote";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(253)))));
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDate.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(1030, 58);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(101, 29);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Label date";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1131, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPilote);
            this.Controls.Add(this.linkLabelDeco);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Menu";
            this.Text = "Menu Principale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem décalageToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabelDeco;
        private System.Windows.Forms.Label labelPilote;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ToolStripMenuItem gestionDePRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relancePRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesPièceRelancéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suivrePRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lancéUnePRFabriquéToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem validéPRRelancéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listePièceRechangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRFabriquéParFLUXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRRelancéParMPRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRFabriquéPourRelanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPilotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerListeDesPRRelancéesToolStripMenuItem;
    }
}