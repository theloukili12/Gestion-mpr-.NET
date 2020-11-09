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
    public partial class Form_PiloteSupprimé : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        public Form_PiloteSupprimé()
        {
            InitializeComponent();
        }

        private void Form_PiloteSupprimé_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            comboBox2.Visible = false;
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            cmd = new SqlCommand("select * from poste", cnx);
            DataTable t = new DataTable();
            t.Load(cmd.ExecuteReader());
            Program.remplir_combobox(comboBox1, t, "Nom_Poste", "Numero_Poste");
            cnx.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            //if (comboBox1.Text != "FLUX" && comboBox1.Text != "MPR" && comboBox1.Text != "ADMIN")
            //{
            //    label2.Visible = false;
            //    comboBox2.Visible = false;
            //    MessageBox.Show("aezfazef", "");
            //}
            //else if (comboBox1.Text == "FLUX" || comboBox1.Text == "MPR" || comboBox1.Text == "ADMIN")
            //{
            //    if (cnx.State == ConnectionState.Closed)
            //        cnx.Open();
            //    cmd = new SqlCommand("select Upper(SUBSTRING(Nom,1,1))+Lower(SUBSTRING(Nom,2,len(nom)))+' '+Upper(SUBSTRING(Prenom,1,1))+Lower(SUBSTRING(Prenom,2,len(Prenom))) as smiya , numero from Pilote where poste = @poste", cnx);
            //    cmd.Parameters.AddWithValue("@poste", comboBox1.SelectedValue);
            //    DataTable dt = new DataTable();
            //    dt.Load(cmd.ExecuteReader());
            //    Program.remplir_combobox(comboBox2, dt, "smiya", "numero");
            //    cnx.Close();
            //    label2.Visible = true;
            //    comboBox2.Visible = true;
            //}
        }

       

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "FLUX" && comboBox1.Text != "MPR" && comboBox1.Text != "ADMIN")
                {
                    label2.Visible = false;
                    comboBox2.Visible = false;
                 
                }
                else if (comboBox1.Text == "FLUX" || comboBox1.Text == "MPR" || comboBox1.Text == "ADMIN")
                {
                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    cmd = new SqlCommand("select Upper(SUBSTRING(Nom,1,1))+Lower(SUBSTRING(Nom,2,len(nom)))+' '+Upper(SUBSTRING(Prenom,1,1))+Lower(SUBSTRING(Prenom,2,len(Prenom))) as smiya , numero from Pilote where poste = @poste", cnx);
                    cmd.Parameters.AddWithValue("@poste", comboBox1.SelectedValue);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    Program.remplir_combobox(comboBox2, dt, "smiya", "numero");
                    cnx.Close();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValide_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.ToString() == "[choisir]")
            {
                MessageBox.Show("Choisir le pilote a supprimé", "");
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Voulez-vous supprimer ce pilote", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {


                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    cmd = new SqlCommand("delete pilote where numero = '"+comboBox2.SelectedValue+"'", cnx);
                    int re = cmd.ExecuteNonQuery();
                    if (re > 0)
                        MessageBox.Show("Pilote bien supprimé", "Message");
                    else
                        MessageBox.Show("probleme du suppression de pilote", "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Form_PiloteSupprimé_Load(sender, e);
                    cnx.Close();
                }

            }
        }
    }
}
