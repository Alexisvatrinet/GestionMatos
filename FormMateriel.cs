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

namespace PPE2
{
    public partial class FormMateriel : Form
    {
        public int q = 0;
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public FormMateriel()
        {
            InitializeComponent();
        }

        private void modifierBoutton()
        {
            buttonAjouter.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonValider.Enabled = true;
            buttonCancel.Enabled = true;
        }

        private void FormMateriel_Load(object sender, EventArgs e)
        {
            buttonCancel.Enabled = false;
            buttonValider.Enabled = false;
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "SELECT * FROM Materiel";
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

        private void ajouter()
        {
            string nom = textBoxNom.Text;
            string site = textBoxSite.Text;
            string desc = textBoxDesc.Text;
            int mtbf = int.Parse(textBoxMtbf.Text);
            cn.Open();
            cmd.CommandText = "INSERT INTO Materiel VALUES ";

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 )
            {
                ListViewItem objet = listView1.SelectedItems[0];
                textBoxNom.Text = objet.SubItems[1].Text;
                textBoxSite.Text = objet.SubItems[2].Text;
                textBoxMtbf.Text = objet.SubItems[3].Text;
                textBoxDesc.Text = objet.SubItems[4].Text;
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            ListViewItem aled = listView1.SelectedItems[2];
            textBoxDesc.Text = aled.ToString();
            //switch (q)
            //{
            //    case 1:
            //        break;
            //}
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            q = 1;
            modifierBoutton();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            q = 2;
            modifierBoutton();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            q = 3;
            modifierBoutton();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
