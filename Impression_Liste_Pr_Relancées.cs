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
    public partial class Impression_Liste_Pr_Relancées : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        public Impression_Liste_Pr_Relancées()
        {
            InitializeComponent();
        }

        private void Impression_Liste_Pr_Relancées_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Impression_PR_fabRel.DataTable_ListePr_Relancées' table. You can move, or remove it, as needed.
            this.DataTable_ListePr_RelancéesTableAdapter.Fill(this.DataSet_Impression_PR_fabRel.DataTable_ListePr_Relancées);
            this.reportViewer1.RefreshReport();
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            cmd = new SqlCommand(" select * from dbo.Liste_Pr_Relnacées() order by Designation", cnx);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Program.remplir_combobox(comboBoxRef, dt, "Ref", "Ref");
            Program.remplir_combobox(comboBoxDes, dt, "designation", "Ref");
            cnx.Close();

        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            try
            {


                if (comboBoxDes.Text.ToString() == "[choisir]" && dateTimePicker1.Text == DateTime.Now.Date.ToShortDateString())
                {
                    this.DataTable_ListePr_RelancéesTableAdapter.Fill(this.DataSet_Impression_PR_fabRel.DataTable_ListePr_Relancées);
                    this.reportViewer1.RefreshReport();
                }
                if (comboBoxDes.Text.ToString() != "[choisir]" && dateTimePicker1.Text == DateTime.Now.Date.ToShortDateString())
                {
                    this.DataTable_ListePr_RelancéesTableAdapter.FillByPR(this.DataSet_Impression_PR_fabRel.DataTable_ListePr_Relancées, comboBoxRef.SelectedValue.ToString());
                    this.reportViewer1.RefreshReport();
                }
                if (comboBoxDes.Text.ToString() == "[choisir]" && dateTimePicker1.Text != DateTime.Now.Date.ToShortDateString())
                {
                    this.DataTable_ListePr_RelancéesTableAdapter.FillBydate(this.DataSet_Impression_PR_fabRel.DataTable_ListePr_Relancées,dateTimePicker1.Value,dateTimePicker2.Value);
                    this.reportViewer1.RefreshReport();
                }
                if (comboBoxDes.Text.ToString() != "[choisir]" && dateTimePicker1.Text != DateTime.Now.Date.ToShortDateString())
                {
                    this.DataTable_ListePr_RelancéesTableAdapter.FillBy_all(this.DataSet_Impression_PR_fabRel.DataTable_ListePr_Relancées,comboBoxRef.SelectedValue.ToString(),dateTimePicker1.Value,dateTimePicker2.Value);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxRef.Text = "[choisir]";
            comboBoxDes.Text = "[choisir]";
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }
    }
}
