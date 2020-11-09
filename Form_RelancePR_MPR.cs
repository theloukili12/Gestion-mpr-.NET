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
using System.Windows.Forms;


namespace Gestion_MPR
{
    public partial class Form_RelancePR_MPR : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        DataTable t;
       

        public Form_RelancePR_MPR()
        {
            InitializeComponent();
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            if (comboBoxRef.Text=="[Choisir]" || comboBoxDesig.Text=="[Choisir]" || numericUpDownqte.Value==0 || string.IsNullOrEmpty(comboBoxDefault.Text) || (radioButtonRel.Checked==false && radioButtonRet.Checked==false) || numericUpDownExc.Value==0 )
                MessageBox.Show("Tous les champs sont obligatoire !","Attention",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    cmd = new SqlCommand("INSERT INTO PR_Relancé (PR, QTE_Probleme, [Default], Commentaire, Decision, date_Probleme, Pilote, semaine_expedition) "
                        + "  VALUES (@ref,@qte,@default,@comm,@deci,@date,@pilo,@exp)", cnx);

                    cmd.Parameters.AddWithValue("@ref",comboBoxRef.SelectedValue);
                    cmd.Parameters.AddWithValue("@qte",numericUpDownqte.Value);
                    cmd.Parameters.AddWithValue("@default",comboBoxDefault.Text);
                    cmd.Parameters.AddWithValue("@comm",textBoxComm.Text);
                    string dec = this.radioButtonRet.Checked==true ? "Retouche" : "Relance" ;

                    cmd.Parameters.AddWithValue("@deci",dec);
                    cmd.Parameters.AddWithValue("@date",DateTime.Now);
                    cmd.Parameters.AddWithValue("@pilo",FormAuthentification.utilisateur.ToString());
                    cmd.Parameters.AddWithValue("@exp", numericUpDownExc.Value);
                    
                    int resu = cmd.ExecuteNonQuery();

                    if (resu > 0)
                    {
                        
                        MessageBox.Show("Bien Enregistré ", "Message");
                    }
                    else
                    {
                        
                        MessageBox.Show("Erreur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur : Exception");
                }
                finally
                {
                    cnx.Close();
                }
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Form_SaisiProbleme_Load(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("select * from pr order by designation", cnx);
                t = new DataTable();
                t.Load(cmd.ExecuteReader());
                Program.remplir_combobox(comboBoxRef, t, "Ref", "Ref");
                Program.remplir_combobox(comboBoxDesig, t, "Designation", "Ref");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception");
            }
        }

       

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            comboBoxRef.SelectedText = "[Choisir]";
            comboBoxDesig.SelectedText = "[Choisir]";
            numericUpDownqte.Value = 0;
            comboBoxDefault.Text = "";
            radioButtonRel.Checked = false;
            radioButtonRet.Checked = false;
            textBoxComm.Text = "";
            numericUpDownExc.Value = 0;

        }

  
    }
}
