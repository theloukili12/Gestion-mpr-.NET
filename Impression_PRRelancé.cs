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
    public partial class Impression_PRRelancé : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        public Impression_PRRelancé()
        {
            InitializeComponent();
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            if (comboBoxDes.Text.ToString() == "[choisir]" && comboBoxDefault.Text=="" && dateTimePicker1.Text == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("Aucun filtrage");
                this.DataTable_PR_RelancéTableAdapter.Fill(this.DataSet_impression_PR_Relancé.DataTable_PR_Relancé);
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxDes.Text.ToString() != "[choisir]" && comboBoxDefault.Text == "" && dateTimePicker1.Text == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("filtrage par pr");
                this.DataTable_PR_RelancéTableAdapter.FillBy_PR(this.DataSet_impression_PR_Relancé.DataTable_PR_Relancé,comboBoxRef.SelectedValue.ToString());
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxDes.Text.ToString() == "[choisir]" && comboBoxDefault.Text != "" && dateTimePicker1.Text == DateTime.Now.Date.ToShortDateString())
            {

                MessageBox.Show("filtrage par default" + comboBoxDefault.Text.ToString());
                this.DataTable_PR_RelancéTableAdapter.FillBy_default(this.DataSet_impression_PR_Relancé.DataTable_PR_Relancé,comboBoxDefault.Text.ToString());
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxDes.Text.ToString() == "[choisir]" && comboBoxDefault.Text == "" && dateTimePicker1.Text != DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("filtrage par date");
                this.DataTable_PR_RelancéTableAdapter.FillBy_date(this.DataSet_impression_PR_Relancé.DataTable_PR_Relancé,dateTimePicker1.Value , dateTimePicker2.Value);
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxDes.Text.ToString() != "[choisir]" && comboBoxDefault.Text != "" && dateTimePicker1.Text != DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("filtrage par tous");
                this.DataTable_PR_RelancéTableAdapter.FillBy_all(this.DataSet_impression_PR_Relancé.DataTable_PR_Relancé,comboBoxRef.SelectedValue.ToString(),comboBoxDefault.Text.ToString(), dateTimePicker1.Value, dateTimePicker2.Value);
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxDes.Text.ToString() != "[choisir]" && comboBoxDefault.Text != "" && dateTimePicker1.Text == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("filtrage par pr et default");
                this.DataTable_PR_RelancéTableAdapter.FillBy_pr_default(this.DataSet_impression_PR_Relancé.DataTable_PR_Relancé,comboBoxRef.SelectedValue.ToString(),comboBoxDefault.Text.ToString());
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxDes.Text.ToString() != "[choisir]" && comboBoxDefault.Text == "" && dateTimePicker1.Text != DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("filtrage par PR et date");
                this.DataTable_PR_RelancéTableAdapter.FillBy_pr_date(this.DataSet_impression_PR_Relancé.DataTable_PR_Relancé, comboBoxRef.SelectedValue.ToString(), dateTimePicker1.Value, dateTimePicker2.Value);
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxDes.Text.ToString() == "[choisir]" && comboBoxDefault.Text != "" && dateTimePicker1.Text != DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("filtrage par Date et default");
                this.DataTable_PR_RelancéTableAdapter.FillBy_defalut_date(this.DataSet_impression_PR_Relancé.DataTable_PR_Relancé,  comboBoxDefault.Text.ToString(), dateTimePicker1.Value, dateTimePicker2.Value);
                this.reportViewer1.RefreshReport();
            }
        }

        private void Impression_PRRelancé_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_impression_PR_Relancé.DataTable_PR_Relancé' table. You can move, or remove it, as needed.
            this.DataTable_PR_RelancéTableAdapter.Fill(this.DataSet_impression_PR_Relancé.DataTable_PR_Relancé);
            this.reportViewer1.RefreshReport();
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            cmd = new SqlCommand("select distinct ref , designation from dbo.LISTE_PR_Relancé() order by Designation", cnx);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Program.remplir_combobox(comboBoxRef, dt, "ref", "ref");
            Program.remplir_combobox(comboBoxDes, dt, "designation", "ref");
            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxDefault.Text = "";
            comboBoxRef.Text = "[choisir]";
            comboBoxDes.Text = "[choisir]";
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }
    }
}
