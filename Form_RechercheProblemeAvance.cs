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
    public partial class Form_RechercheProblemeAvance : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        DataTable dt;
        public static string decision;
        public Form_RechercheProblemeAvance()
        {
            InitializeComponent();
        }

        private void Form_RechercheProblemeAvance_Load(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            cmd = new SqlCommand("select * from PR order by designation",cnx);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            

            Program.remplir_combobox(comboBoxRef, dt, "Ref", "Ref");
            Program.remplir_combobox(comboBoxdesi, dt, "Designation", "Ref");

            cmd = new SqlCommand("select * from PR where ref not in ('[choisir]')", cnx);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        

        private void comboBoxRef_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("select Designation from PR "
                    + " where Ref='" + comboBoxRef.Text + "' ", cnx);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                //MessageBox.Show("La designation est :" +);
                comboBoxdesi.SelectedText = dt.Rows[0][0].ToString();

                cnx.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception");
            }
        }

        private void comboBoxdesi_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("select ref from PR "
                    + " where designation='" + comboBoxdesi.Text + "' ", cnx);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                //MessageBox.Show("La designation est :" +);
                comboBoxRef.Text = dt.Rows[0][0].ToString();

                cnx.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception");
            }
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("select * from Probleme "+
                    " where pr like '%@ref%' or [Default]=@def or decision like @dec or date_Probleme between @date1 and @date2 ", cnx);
                cmd.Parameters.AddWithValue("@ref",comboBoxRef.Text);
                cmd.Parameters.AddWithValue("@def",comboBoxDefault.Text);
                cmd.Parameters.AddWithValue("@dec",comboBoxdec.Text);
                cmd.Parameters.AddWithValue("@date1",Convert.ToDateTime(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("@date2",Convert.ToDateTime(dateTimePicker2.Text));
                DataTable rech = new DataTable();
                rech.Load(cmd.ExecuteReader());

                if (rech.Rows.Count > 0)
                {
                    MessageBox.Show("Probleme Trouvé", "Message");
                    dataGridView1.DataSource=rech;
                  }
                else
                    MessageBox.Show("Le probleme est introuvable", "attention ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cnx.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Erreur :Exception"); 
            }
        }

        private void buttontous_Click(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            cmd = new SqlCommand("select * from PR where ref not in ('[choisir]')", cnx);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        

        

       
    }
}
