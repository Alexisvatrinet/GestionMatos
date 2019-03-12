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

namespace PPE2
{
    public partial class FormSite : Form
    {
        public int q = 0;
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public FormMateriel()
        public FormSite()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            buttonAjouter.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonValider.Enabled = true;
            buttonCancel.Enabled = true;
        }

        private void FormSite_Load(object sender, EventArgs e)
        {
            buttonCancel.Enabled = false;
            buttonValider.Enabled = false;
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "SELECT * FROM FormSite";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lvi = new ListViewItem(dr["id"].ToString());
                lvi.SubItems.Add(dr["nom"].ToString());
                lvi.SubItems.Add(dr["id_utilisateur"].ToString());
                listView1.Items.Add(lvi);
            }
            cn.Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string site = textBoxSite.Text;
            string desc = textBoxDesc.Text;
            int mtbf = int.Parse(textBoxMtbf.Text);
            cn.Open();
            cmd.CommandText = "INSERT INTO  VALUES ";
        }
    }
}
