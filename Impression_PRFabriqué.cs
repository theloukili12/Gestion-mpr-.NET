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
    public partial class Impression_PRFabriqué : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        public Impression_PRFabriqué()
        {
            InitializeComponent();
        }

        private void Impression_PRFabriqué_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Impression.DataTable_PRFabriqué' table. You can move, or remove it, as needed.
            this.DataTable_PRFabriquéTableAdapter.Fill(this.DataSet_Impression.DataTable_PRFabriqué);
            this.reportViewer1.RefreshReport();

            if (cnx.State == ConnectionState.Closed) cnx.Open();
            cmd = new SqlCommand("select distinct ref , designation from dbo.LISTE_PR_Fabriqué() order by Designation", cnx);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Program.remplir_combobox(comboBoxRef, dt, "Ref", "Ref");
            Program.remplir_combobox(comboBoxDes, dt, "designation", "Ref");


            cnx.Close();
            
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
          
            if (comboBoxDes.Text.ToString() == "[choisir]" && numericUpDownSemaine.Value == 0   && dateTimePicker1.Text == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show("Aucun filtrage");
                this.DataTable_PRFabriquéTableAdapter.Fill(this.DataSet_Impression.DataTable_PRFabriqué);
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxRef.Text.ToString() != "[choisir]" && numericUpDownSemaine.Value == 0 && dateTimePicker1.Text == DateTime.Now.Date.ToShortDateString())
            {
                this.DataTable_PRFabriquéTableAdapter.FillByPR(this.DataSet_Impression.DataTable_PRFabriqué,comboBoxRef.SelectedValue.ToString());
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxRef.Text.ToString() == "[choisir]" && numericUpDownSemaine.Value != 0 && dateTimePicker1.Text == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show(" filtrage par semaine ");
                this.DataTable_PRFabriquéTableAdapter.FillBySemaine(this.DataSet_Impression.DataTable_PRFabriqué,Convert.ToInt16(numericUpDownSemaine.Value));
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxRef.Text.ToString() == "[choisir]" && numericUpDownSemaine.Value == 0 && dateTimePicker1.Text != DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show(" filtrage par date ");
                this.DataTable_PRFabriquéTableAdapter.FillBydate(this.DataSet_Impression.DataTable_PRFabriqué, dateTimePicker1.Value,dateTimePicker2.Value);
                this.reportViewer1.RefreshReport();
            }

            else if (comboBoxRef.Text.ToString() != "[choisir]" && numericUpDownSemaine.Value != 0 && dateTimePicker1.Text != DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show(" filtrage par all ");
                this.DataTable_PRFabriquéTableAdapter.FillByAll(this.DataSet_Impression.DataTable_PRFabriqué,comboBoxRef.SelectedValue.ToString(),Convert.ToInt16(numericUpDownSemaine.Value),dateTimePicker1.Value,dateTimePicker2.Value);
                this.reportViewer1.RefreshReport();

            }
            else if (comboBoxRef.Text.ToString() != "[choisir]" && numericUpDownSemaine.Value != 0 && dateTimePicker1.Text == DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show(" filtrage par pr ans semaine ");
                this.DataTable_PRFabriquéTableAdapter.FillBy_PR_Semaine(this.DataSet_Impression.DataTable_PRFabriqué,comboBoxRef.SelectedValue.ToString(),Convert.ToInt16(numericUpDownSemaine.Value));
                this.reportViewer1.RefreshReport();
            }
            else if (comboBoxRef.Text.ToString() != "[choisir]" && numericUpDownSemaine.Value == 0 && dateTimePicker1.Text != DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show(" filtrage par pr and date ");
            this.DataTable_PRFabriquéTableAdapter.FillBy_PR_date(this.DataSet_Impression.DataTable_PRFabriqué,comboBoxRef.SelectedValue.ToString(),dateTimePicker1.Value,dateTimePicker2.Value);
            this.reportViewer1.RefreshReport();
            }
            else if (comboBoxRef.Text.ToString() == "[choisir]" && numericUpDownSemaine.Value != 0 && dateTimePicker1.Text != DateTime.Now.Date.ToShortDateString())
            {
                MessageBox.Show(" filtrage par semaine and date ");
                this.DataTable_PRFabriquéTableAdapter.FillBy_semaine_date(this.DataSet_Impression.DataTable_PRFabriqué, Convert.ToInt16(numericUpDownSemaine.Value), dateTimePicker1.Value, dateTimePicker2.Value);
                this.reportViewer1.RefreshReport();
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDownSemaine.Value = 0;
            comboBoxRef.Text = "[choisir]";
            comboBoxDes.Text = "[choisir]";
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }
    }
}
