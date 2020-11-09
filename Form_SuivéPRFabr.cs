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
    public partial class Form_SuivéPRFabr : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        DataTable dt;

        public Form_SuivéPRFabr()
        {
            InitializeComponent();
        }

        private void Form_SuivéPRFabr_Load(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("SELECT PR.Ref, PR.Designation, PR_Fabriqué.Qte_Fabriqué, PR_Fabriqué.Semaine"
                                    +", PR_Fabriqué.Date,PR_Fabriqué.Pilote, PR_Fabriqué.Capacité_emballage"
                                      + " FROM     PR INNER JOIN PR_Fabriqué ON PR.Ref = PR_Fabriqué.Ref where "
                                        +" relance='Non' ORDER BY Designation  ", cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception");
            }
        }

        private void buttonActualiser_Click(object sender, EventArgs e)
        {
            Form_SuivéPRFabr_Load(sender, e);
        }
    }
}
