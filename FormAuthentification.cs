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
    public partial class FormAuthentification : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        DataTable dt;
        public static string poste,utilisateur;


        public FormAuthentification()
        {
            InitializeComponent();
        }

        private void buttonAnuuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConnecte_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("select * from Poste po join pilote p on po.Numero_Poste=p.poste "
                    + " where po.Nom_Poste=@poste and p.nom=@nom and passeword=@PS ", cnx);
               
                cmd.Parameters.AddWithValue("@poste",listBox1.Text);
                cmd.Parameters.AddWithValue("@nom",textBoxPilote.Text);
                cmd.Parameters.AddWithValue("@PS",textBoxPS.Text);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                if (dt.Rows.Count > 0)
                {
                     cmd = new SqlCommand("select Upper(SUBSTRING(Nom,1,1))+Lower(SUBSTRING(Nom,2,len(nom)))+' '+Upper(SUBSTRING(Prenom,1,1))+Lower(SUBSTRING(Prenom,2,len(Prenom))) from Pilote where nom = @nom", cnx);
                    cmd.Parameters.Add("@nom", textBoxPilote.Text);
                    string nom = cmd.ExecuteScalar().ToString();
                    FormAuthentification.utilisateur = nom.ToString();
                    FormAuthentification.poste = listBox1.Text.ToString();
                    Form_Menu m = new Form_Menu();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Poste ou Nom ou Mot de passe incorrecte", "Message");
                }
                cnx.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception");
            }
        }

        private void FormAuthentification_Load(object sender, EventArgs e)
        {
            poste = "";
            utilisateur = "";
        }

        private void FormAuthentification_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
