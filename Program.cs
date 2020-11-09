using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

//using System.Configuration; /// il faut ajouter la référence Sytem.Confirguration via --> Références dans le dossier racine de l'application
//using System.Data;
//using System.Data.SqlClient;

namespace Gestion_MPR
{
    static class Program
    {
        public static string str = "Data Source=.;Initial Catalog=Gestion_MPR;Integrated Security=True";

        public static void remplir_combobox(ComboBox cb, DataTable dt_resultats, string ColonneAfficher, string ColonneSelectionner)
        {

            //MessageBox.Show(dt_resultats.Rows.Count.ToString());
            cb.DataSource = dt_resultats;

            // afficher l'element desiré
            cb.DisplayMember = ColonneAfficher;

            // selectionner l'element
            cb.ValueMember = ColonneSelectionner;

            cb.Text = "[choisir]";

        }

        public static void Remplir_ListBox(ListBox lb, DataTable dt_resultats, string ColonneAfficher, string ColonneSelectionner)
        {

            //MessageBox.Show(dt_resultats.Rows.Count.ToString());
            lb.DataSource = dt_resultats;

            // afficher l'element desiré
            lb.DisplayMember = ColonneAfficher;

            // selectionner l'element
            lb.ValueMember = ColonneSelectionner;

            

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthentification());
        }
    }
}
