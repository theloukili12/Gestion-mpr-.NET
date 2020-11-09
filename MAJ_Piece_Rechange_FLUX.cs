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
    public partial class MAJ_Piece_Rechange_FLUX : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd;
        
        public MAJ_Piece_Rechange_FLUX()
        {
            InitializeComponent();
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            textBoxDes.ResetText();
            textBoxLib.ResetText();
            textBoxRef.ResetText();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxRef.Text) || string.IsNullOrEmpty(textBoxDes.Text))
                MessageBox.Show("Les Champs Réference , Désignation sont obligatoire","Attention",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    cmd = new SqlCommand("insert into pr values(@ref,@des,@lib)", cnx);
                    cmd.Parameters.AddWithValue("@ref", textBoxRef.Text);
                    cmd.Parameters.AddWithValue("@des", textBoxDes.Text);
                    cmd.Parameters.AddWithValue("@lib", textBoxLib.Text);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                        MessageBox.Show("La pièce est bien ajouter", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Probleme d'ajout !");
                    cnx.Close();
                    MAJ_Piece_Rechange_Load(sender, e);

                }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.Message, "Erreur : Exception");
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            Form_PRsupprimé rps = new Form_PRsupprimé();
            rps.ShowDialog();
        }

        private void MAJ_Piece_Rechange_Activated(object sender, EventArgs e)
        {

        }

        private void MAJ_Piece_Rechange_Load(object sender, EventArgs e)
        {
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();

            cmd = new SqlCommand("select * from pr order by designation", cnx);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;

            cnx.Close();
        }

        private void MAJ_Piece_Rechange_Activated_1(object sender, EventArgs e)
        {
            MAJ_Piece_Rechange_Load(sender, e);
        }

       
    }
}
