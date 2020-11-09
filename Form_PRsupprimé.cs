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
    public partial class Form_PRsupprimé : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        DataTable dt;
        public static string PRsupp;
        public Form_PRsupprimé()
        {
            InitializeComponent();
        }

        private void Form_PRsupprimé_Load(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            cmd = new SqlCommand("select * from pr order by designation", cnx);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
           
            Program.remplir_combobox(comboBoxDes, dt, "designation", "Ref");

            cnx.Close();
        }

        private void buttonValide_Click(object sender, EventArgs e)
        {
            if (comboBoxDes.Text != "[choisir]")
            {
                DialogResult reponse = MessageBox.Show("Voulez-vous supprimer ?",
                    "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    
                    MAJ_Piece_Rechange_FLUX maj = new MAJ_Piece_Rechange_FLUX();
                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    cmd = new SqlCommand("delete pr where ref= @ref",cnx);
                    cmd.Parameters.AddWithValue("@ref", comboBoxDes.SelectedValue);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                        MessageBox.Show("La Pièce est bien supprimé", "Message");
                        
                    else
                        MessageBox.Show("Probleme du suppression", "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    cnx.Close();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Choisir la commandé pour supprimé", "message");
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Form_PRsupprimé ps = new Form_PRsupprimé();
            this.Close();
        }
    }
}
