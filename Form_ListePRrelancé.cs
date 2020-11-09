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
    public partial class Form_ListePRrelancé : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        DataTable dt;
        public Form_ListePRrelancé()
        {
            InitializeComponent();
        }

         public  void recherche(string reference)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("select * from probleme where Ref = @ref", cnx);
                cmd.Parameters.AddWithValue("@ref", reference);
                DataTable t_recherche = new DataTable();
                t_recherche.Load(cmd.ExecuteReader());
                if (t_recherche.Rows.Count > 0)
                {
                    dataGridView1.DataSource = t_recherche;

                }
                else
                    MessageBox.Show("Reference Recherché introuvable dans la liste", "Message");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception");
            }
        }

        private void Form_AfficheProbls_Load(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("select distinct pr,designation from PR_Relancé r join pr on pr.ref=r.pr where decision='relance' order by designation", cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                Program.remplir_combobox(comboBoxRef, dt, "designation", "pr");
                cmd = new SqlCommand("SELECT PR.Ref, PR.Designation, PR_Relancé.QTE_Probleme, PR_Relancé.[Default], PR_Relancé.Commentaire, PR_Relancé.Decision, PR_Relancé.date_Probleme, PR_Relancé.Pilote, PR_Relancé.Semaine_expedition "
                    + "   FROM     PR INNER JOIN PR_Relancé ON PR.Ref = PR_Relancé.PR where Decision='relance' order by date_Probleme desc", cnx);
                DataTable aff = new DataTable();
                aff.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = aff;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonrecherche_Click(object sender, EventArgs e)
        {
            
             try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("SELECT PR.Ref, PR.Designation, PR_Relancé.QTE_Probleme, PR_Relancé.[Default], PR_Relancé.Commentaire, PR_Relancé.Decision, PR_Relancé.date_Probleme, PR_Relancé.Pilote, PR_Relancé.Semaine_expedition "
                    + "   FROM     PR INNER JOIN PR_Relancé ON PR.Ref = PR_Relancé.PR where Decision='relance' and pr=@ref order by date_Probleme desc", cnx);
                cmd.Parameters.AddWithValue("@ref", comboBoxRef.SelectedValue);
                DataTable t_recherche = new DataTable();
                t_recherche.Load(cmd.ExecuteReader());
                if (t_recherche.Rows.Count > 0)
                {
                    dataGridView1.DataSource = t_recherche;

                }
                else
                    MessageBox.Show("Reference Recherché introuvable dans la liste", "Message");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception");
            }
        }

        public void Form_AfficheProbls_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBoxRef_Validated(object sender, EventArgs e)
        {
            //if (cnx.State == ConnectionState.Closed)
            //    cnx.Open();
            //string ver_ref = comboBoxRef.Text.ToString();
            //cmd = new SqlCommand("select * from pr where ref=@re", cnx);
            //cmd.Parameters.AddWithValue("@re", ver_ref);
            //DataTable ver = new DataTable();
            //ver.Load(cmd.ExecuteReader());
            //if (ver.Rows.Count > 0)
            //{
            //    comboBoxDes.SelectedText = ver.Rows[0][1].ToString();
            //}
            //else
            //    MessageBox.Show("Le reference Saisi est introuvable", "");


            //cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cnx.State == ConnectionState.Closed)
                cnx.Open();

            cmd = new SqlCommand("select * from PR_Relancé where decision='relance'order by date_probleme" , cnx);
            DataTable aff = new DataTable();
            aff.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = aff;
            cnx.Close();
        }
 
    }
}
