using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_MPR
{
    public partial class Form_SaisiPRFab_FLUX : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        
        public Form_SaisiPRFab_FLUX()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_SaisiPRFab_FLUX_Load(object sender, EventArgs e)
        {
            labelQteRelancé.Visible = false;
            numericUpDownRelance.Visible = false;
            labelQteFabriqué.Visible = false;
            numericUpDownFab.Visible = false;
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("select * from pr", cnx);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                Program.remplir_combobox(comboBoxRef, dt, "Ref", "Ref");
                Program.remplir_combobox(comboBoxDes, dt, "designation", "ref");

                cnx.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Erreur : Exception");
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonOui_CheckedChanged(object sender, EventArgs e)
        {
            labelQteRelancé.Visible = true;
            numericUpDownRelance.Visible = true;
            numericUpDownRelance.Value = 0;
            labelQteFabriqué.Visible = false;
            numericUpDownFab.Visible = false;
            numericUpDownFab.Value = 0;
        }

        private void radioButtonNon_CheckedChanged(object sender, EventArgs e)
        {
            labelQteRelancé.Visible = false;
            numericUpDownRelance.Visible = false;
            numericUpDownRelance.Value = 0;
            labelQteFabriqué.Visible = true;
            numericUpDownFab.Visible = true;
            numericUpDownFab.Value = 0;
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            numericUpDownEmb.Value = 0;
            numericUpDownRelance.Value = 0;
            numericUpDownSemaine.Value = 0;
            radioButtonNon.Checked = false;
            radioButtonOui.Checked = false;
            comboBoxRef.SelectedValue = "[choisir]";
            comboBoxDes.SelectedValue = "[choisir]";
            labelQteRelancé.Visible = false;
            numericUpDownRelance.Visible = false;
            
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            if ( numericUpDownEmb.Value == 0 || (radioButtonNon.Checked == false && radioButtonOui.Checked == false) || 
                (radioButtonNon.Checked == true && numericUpDownRelance.Value != 0 && numericUpDownFab.Value==0) || 
                (radioButtonOui.Checked == true && numericUpDownRelance.Value == 0 && numericUpDownFab.Value != 0) ||
                numericUpDownSemaine.Value == 0 || comboBoxRef.SelectedValue.ToString() == "[choisir]" ||
                (radioButtonNon.Checked==true && numericUpDownFab.Value==0) || (radioButtonOui.Checked==true && numericUpDownRelance.Value==0))
            {
                MessageBox.Show("Tous les champs sont Obligatoire", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(numericUpDownEmb.Value<numericUpDownRelance.Value || ( numericUpDownEmb.Value<numericUpDownFab.Value))
                    MessageBox.Show("la Capacité d'emballage doit être Superieur a la Quantité","Attention" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        if (cnx.State == ConnectionState.Closed) cnx.Open();
                        cmd = new SqlCommand("INSERT INTO PR_Fabriqué (Capacité_emballage, Relance, Qte_Relance, Semaine, Ref, Qte_Fabriqué, Date,pilote)"
                                            +" VALUES (@emb,@relance,@qte,@sem,@ref,@fab,@date,@pilote)", cnx);
                        cmd.Parameters.AddWithValue("@emb", numericUpDownEmb.Value);
                        string rel = this.radioButtonOui.Checked==true ? "Oui" : "Non" ;

                        cmd.Parameters.AddWithValue("@relance", rel);
                        if(rel=="Oui")
                            cmd.Parameters.AddWithValue("@qte", numericUpDownRelance.Value);
                        else if (rel=="Non")
                            cmd.Parameters.AddWithValue("@qte",0 );
                        cmd.Parameters.AddWithValue("@sem", numericUpDownSemaine.Value);
                        cmd.Parameters.AddWithValue("@ref", comboBoxRef.SelectedValue);
                        if (rel == "Oui")
                            cmd.Parameters.AddWithValue("@fab", 0);
                        else if (rel == "Non")
                            cmd.Parameters.AddWithValue("@fab", numericUpDownFab.Value);
                        cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTime.Now));
                        cmd.Parameters.AddWithValue("@pilote", Convert.ToString(FormAuthentification.utilisateur));
                        
                        int res = cmd.ExecuteNonQuery();
                        if(res>0)
                            MessageBox.Show("cet tranche est automatiquement envoyé au liste de PR fabriqué pour le Relance","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Probleme d'enregistrement","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        cnx.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur : Exception");
                    }
                }

            }
        }

        
    }
}
