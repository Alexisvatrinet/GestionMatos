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
        public FormSite()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem objet = listView1.SelectedItems[0];
                textBoxVille.Text = objet.SubItems[1].Text;
                textBoxAdresse.Text = objet.SubItems[2].Text;
                textBoxTel.Text = objet.SubItems[3].Text;
                textBoxMail.Text = objet.SubItems[4].Text;
                textBoxCp.Text = objet.SubItems[5].Text;
                textBoxComm.Text = objet.SubItems[6].Text;
            }
        }

        private void modifierBoutton()
        {
            buttonAjouter.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonValider.Enabled = true;
            buttonCancel.Enabled = true;
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            q = 2;
            modifierBoutton();
        }

        private void FormSite_Load(object sender, EventArgs e)
        {
            buttonCancel.Enabled = false;
            buttonValider.Enabled = false;
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "SELECT * FROM Sites";
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
            string Ville = textBoxVille.Text;
            string Adresse = textBoxAdresse.Text;
            int Téléphone = int.Parse(textBoxTel.Text);
            string Mail = textBoxMail.Text;
            string CodePostal = textBoxCp.Text;
            string Commentaire = textBoxComm.Text; 

            cn.Open();
            cmd.CommandText = "INSERT INTO Sites VALUES ";
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            q = 1;
            ajouter();
            modifierBoutton();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            ListViewItem aled = listView1.SelectedItems[2];
            textBoxComm.Text = aled.ToString();
            //switch (q)
            //{
            //    case 1:
            //        break;
            //}
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            q = 3;
            modifierBoutton();
        }
    }
}
