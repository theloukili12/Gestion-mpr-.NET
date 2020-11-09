using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_MPR
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            labelPilote.Text = "Pilote : "+FormAuthentification.utilisateur;
            labelDate.Text = "Date ouverture: " + DateTime.Now;
            if (FormAuthentification.poste.ToString() == "FLUX")
            {
                décalageToolStripMenuItem.Visible = false;
                gestionDesPilotesToolStripMenuItem.Visible = false;
                
            }
            if (FormAuthentification.poste.ToString() == "MPR")
            {
                suivrePRToolStripMenuItem.Visible = false;
                gestionDesPilotesToolStripMenuItem.Visible = false;
                gestionDePRToolStripMenuItem.Visible = false;
                
            }
        }

        private void aEBSaisiUnProblemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RelancePR_MPR sp = new Form_RelancePR_MPR();
            sp.Show();
        }

        private void fluxAfficherLesPiecesAvecDécalageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListePRrelancé af = new Form_ListePRrelancé();
            af.Show();
        }

        private void linkLabelDeco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez-vous Quitté l'application", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reponse == DialogResult.Yes)
                Application.Exit();
        }

        private void rechercheAvancéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RechercheProblemeAvance rpa = new Form_RechercheProblemeAvance();
            rpa.Show();
        }

        private void suiviLesPRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_SuivéPRFabr spf = new Form_SuivéPRFabr();
            spf.Show();
        }

        private void miseÀJourPieceDeRechangeAjouterModifierSupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAJ_Piece_Rechange_FLUX maj = new MAJ_Piece_Rechange_FLUX();
            maj.Show();
        }

        private void relancePRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RelancePR_MPR rpr = new Form_RelancePR_MPR();
            rpr.Show();
        }

        private void Form_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listeDesPièceRelancéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impression_PRRelancé ip = new Impression_PRRelancé();
            ip.Show();

        }

        private void lancéPRFabriquéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SaisiPRFab_FLUX sprf = new Form_SaisiPRFab_FLUX();
            sprf.Show();
        }

        private void listeDesPRRelancéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListePRrelancé ap = new Form_ListePRrelancé();
            ap.Show();
        }

    

        private void listeDePRFabriquéParFluxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SuivéPRFabr spf = new Form_SuivéPRFabr();
            spf.Show();
        }

        private void listePRRelancéParMPRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListePRrelancé lpr = new Form_ListePRrelancé();
            lpr.Show();
        }

        private void lancéUnePRFabriquéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SaisiPRFab_FLUX spff = new Form_SaisiPRFab_FLUX();
            spff.Show();
        }

        private void validéPRRelancéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Validation_PRrelancé_FLUX vprr = new Form_Validation_PRrelancé_FLUX();
            vprr.Show();
        }

        private void pRFabriquéParFLUXToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form_SuivéPRFabr spf = new Form_SuivéPRFabr();
            spf.Show();
        }

        private void pRRelancéParMPRToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_ListePRrelancé lpr = new Form_ListePRrelancé();
            lpr.Show();
        }

        private void pRFabriquéPourRelanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListePrFabPourRelance lpfr = new Form_ListePrFabPourRelance();
            lpfr.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impression_PRFabriqué prf = new Impression_PRFabriqué();
            prf.Show();
        }

        private void miseÀJourToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Maj_Pilote p = new Maj_Pilote();
            p.Show();
        }

      

    }
}
