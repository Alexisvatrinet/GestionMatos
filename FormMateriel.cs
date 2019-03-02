using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace PPE2
{
    public partial class FormMateriel : Form
    {
        private string connstr;
        private SqlConnection cn;
        private SqlCommand cm;
        private SqlDataReader dr;

     

        public FormMateriel()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AjouterProduit()
        {
            SqlConnection cn;
            SqlCommand cmSQL;
            string strSQL;
      
          
        }

        private void FormMateriel_Load(object sender, EventArgs e)
        {
            connstr = ConfigurationManager.ConnectionStrings["GestionMatos"].
                                 ConnectionString;
        }
    }
}
