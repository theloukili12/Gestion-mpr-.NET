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
    public partial class Form_Validation_PRrelancé_FLUX : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        public Form_Validation_PRrelancé_FLUX()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int index = dataGridView1.CurrentCell.RowIndex;
                int val = Convert.ToInt16(dataGridView1.Rows[index].Cells[1].Value.ToString());
                DialogResult rep = MessageBox.Show("Voulez-vous validé le PR séléctionné", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {

                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    cmd = new SqlCommand("delete PR_Relancé where numero_probleme=@prob", cnx);
                    cmd.Parameters.AddWithValue("@prob", val);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                        MessageBox.Show("Bien validé");
                    Form_Validation_PRrelancé_FLUX_Load(sender, e);
                    cnx.Close();

                }
                else
                {
                    //((DataGridViewCheckBoxCell)dataGridView1.Rows[index].Cells[0]).Selected=true;

                    dataGridView1.CancelEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception");
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            
        }

        private void Form_Validation_PRrelancé_FLUX_Load(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            cmd = new SqlCommand("SELECT Numero_Probleme,PR.Ref, PR.Designation, PR_Relancé.QTE_Probleme, PR_Relancé.[Default], PR_Relancé.date_Probleme, PR_Relancé.Commentaire, PR_Relancé.Decision ,PR_Relancé.Pilote, PR_Relancé.Semaine_expedition "
                    + "   FROM     PR INNER JOIN PR_Relancé ON PR.Ref = PR_Relancé.PR where Decision='relance' order by date_Probleme desc", cnx);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

       
    }
}
