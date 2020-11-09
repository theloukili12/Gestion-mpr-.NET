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
    public partial class Maj_Pilote : Form
    {
        SqlConnection cnx = new SqlConnection(Program.str);
        SqlCommand cmd,cmd1;
        DataTable dt;
        int pilote;

        public Maj_Pilote()
        {
            InitializeComponent();
        }

        private void Maj_Pilote_Load(object sender, EventArgs e)
        {
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                cmd = new SqlCommand("SELECT Pilote.Nom, Pilote.Prenom, Pilote.Passeword,  Poste.Nom_Poste, Poste.Description "
                    + " FROM     Pilote INNER JOIN Poste ON Pilote.Poste = Poste.Numero_Poste ", cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;

                cmd = new SqlCommand("SELECT Numero_Poste, Nom_Poste FROM     Poste", cnx);
                DataTable t = new DataTable();
                t.Load(cmd.ExecuteReader());
                Program.remplir_combobox(comboBoxPoste, t, "Nom_Poste", "Numero_Poste");

                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur : Exception");
            }
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            textBoxCMDP.ResetText();
            textBoxMDP.ResetText();
            textBoxNom.ResetText();
            textBoxPrenom.ResetText();
            comboBoxPoste.ResetText();
        }

        private void textBoxCMDP_Validated(object sender, EventArgs e)
        {
            if (textBoxMDP.Text != textBoxCMDP.Text)
            {
                MessageBox.Show("La confirmation du mot de passe invalide! Réssayé ", "Erreur ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                textBoxCMDP.Select();
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxNom.Text) || string.IsNullOrEmpty(textBoxPrenom.Text) || 
                string.IsNullOrEmpty(textBoxMDP.Text) || string.IsNullOrEmpty(textBoxCMDP.Text) ||
                string.IsNullOrEmpty(comboBoxPoste.Text) )
            {
                MessageBox.Show("Tous les champs sont Obligatoire","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxMDP.Text == textBoxCMDP.Text)
                {
                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    cmd = new SqlCommand("INSERT INTO Pilote (Nom, Prenom, Passeword, Poste) VALUES (@nom,@prenom,@ps,@poste)", cnx);
                    cmd.Parameters.AddWithValue("@nom", textBoxNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", textBoxPrenom.Text);

                    cmd.Parameters.AddWithValue("@ps", textBoxMDP.Text);
                    cmd.Parameters.AddWithValue("@poste", comboBoxPoste.SelectedValue);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                        MessageBox.Show("Le pilote est bien ajouter", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Probleme d'ajout", "Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cnx.Close();
                    Maj_Pilote_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Le mot de passe et la confirmation ne correspond pas,resseyer ", "probleme",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int index = dataGridView1.CurrentRow.Index;
            
            textBoxNom.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBoxMDP.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBoxCMDP.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            comboBoxPoste.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            cmd = new SqlCommand("select numero from pilote where nom=@nom and prenom=@prenom and passeword=@ps and poste=@poste", cnx);
            cmd.Parameters.AddWithValue("@nom", textBoxNom.Text);
            cmd.Parameters.AddWithValue("@prenom", textBoxPrenom.Text);
            cmd.Parameters.AddWithValue("@ps", textBoxMDP.Text);
            cmd.Parameters.AddWithValue("@poste", comboBoxPoste.SelectedValue);
            pilote = Convert.ToInt16(cmd.ExecuteScalar());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
           
            textBoxNom.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBoxPrenom.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBoxMDP.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBoxCMDP.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            comboBoxPoste.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            if (cnx.State == ConnectionState.Closed)
                cnx.Open();
            cmd = new SqlCommand("select numero from pilote where nom=@nom and "
                                +"prenom=@prenom and passeword=@ps and poste=@poste", cnx);
            cmd.Parameters.AddWithValue("@nom", textBoxNom.Text);
            cmd.Parameters.AddWithValue("@prenom", textBoxPrenom.Text);
            cmd.Parameters.AddWithValue("@ps", textBoxMDP.Text);
            cmd.Parameters.AddWithValue("@poste", comboBoxPoste.SelectedValue);
            pilote = Convert.ToInt16(cmd.ExecuteScalar());
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxMDP.Text != textBoxCMDP.Text)
                MessageBox.Show("Le mot de passe et la confirmation ne correspond pas,resseyer ", "probleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {   DialogResult reponse = MessageBox.Show("Voulez-vous modifier ce pilote ?", "Confirmation"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (reponse == DialogResult.Yes)
                    {
                        if (cnx.State == ConnectionState.Closed)
                            cnx.Open();
                        cmd = new SqlCommand("UPDATE Pilote SET Nom = @nom, Prenom = @prenom, Passeword = @ps, Poste = @poste where numero=@pilote", cnx);
                        cmd.Parameters.AddWithValue("@pilote", pilote.ToString());
                        cmd.Parameters.AddWithValue("@nom", textBoxNom.Text.ToString());
                        cmd.Parameters.AddWithValue("@prenom", textBoxPrenom.Text);
                        cmd.Parameters.AddWithValue("@ps", textBoxMDP.Text);
                        cmd.Parameters.AddWithValue("@poste", comboBoxPoste.SelectedValue);
                        int re = cmd.ExecuteNonQuery();

                        if (re > 0)
                            MessageBox.Show("Bien Modifier", "message");
                    }
                    cnx.Close();
                    Maj_Pilote_Load(sender, e);
                }
                catch (Exception ex)
                {

                   MessageBox.Show( ex.Message,"Erreur : Exception");
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            Form_PiloteSupprimé ps = new Form_PiloteSupprimé();
            ps.ShowDialog();

        }

        private void Maj_Pilote_Activated(object sender, EventArgs e)
        {
            Maj_Pilote_Load(sender, e);
        }
    }
}
