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
    public partial class Form_ListePrFabPourRelance : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;

        public Form_ListePrFabPourRelance()
        {
            InitializeComponent();
        }

        private void Form_ListePrFabPourRelance_Load(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            cmd = new SqlCommand("SELECT PR.Ref, PR.Designation, Probleme_fabriqué.QTE_Probleme, Probleme_fabriqué.[Default], Probleme_fabriqué.date_Probleme,date_Validation, Probleme_fabriqué.Commentaire, Probleme_fabriqué.Pilote,  "
                + "  Probleme_fabriqué.Semaine_expedition FROM     Probleme_fabriqué INNER JOIN  PR ON Probleme_fabriqué.PR = PR.Ref order by date_Probleme desc  ", cnx);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource=dt;
            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (cnx.State == ConnectionState.Closed)
            //    cnx.Open();
            //cmd = new SqlCommand("select * from probleme_fabriqué order by date_probleme", cnx);
            //DataTable dt = new DataTable();
            //dt.Load(cmd.ExecuteReader());
            //dataGridView1.DataSource = dt;
            //cnx.Close();

            Form_ListePrFabPourRelance_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
