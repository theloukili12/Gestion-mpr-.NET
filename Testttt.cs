using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_MPR
{
    public partial class Testttt : Form
    {
        public Testttt()
        {
            InitializeComponent();
        }

        private void Testttt_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'DataSet_Impression.DataTable_PRFabriqué' table. You can move, or remove it, as needed.
            this.DataTable_PRFabriquéTableAdapter.Fill(this.DataSet_Impression.DataTable_PRFabriqué);

            this.reportViewer1.RefreshReport();
        }
    }
}
