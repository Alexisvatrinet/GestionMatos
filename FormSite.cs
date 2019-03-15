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

        private void desactiverBox()
        {
            textBoxVille.Enabled = false;
            textBoxAdresse.Enabled = false;
            maskedTextBoxTel.Enabled = false;
            textBoxMail.Enabled = false;
            textBoxCp.Enabled = false;
            textBoxComm.Enabled = false;
            buttonCancel.Enabled = false;
            buttonValider.Enabled = false;
        }

        private void reactiverBox()
        {
            textBoxVille.Enabled = true;
            textBoxAdresse.Enabled = true;
            maskedTextBoxTel.Enabled = true;
            textBoxMail.Enabled = true;
            textBoxCp.Enabled = true;
            textBoxComm.Enabled = true;
            buttonCancel.Enabled = true;
            buttonValider.Enabled = true;
            buttonSupprimer.Enabled = false;
            buttonAjouter.Enabled = false;
            buttonModifier.Enabled = false;
        }

        private void viderBox()
        {
            textBoxVille.Text = "";
            textBoxAdresse.Text = "";
            maskedTextBoxTel.Text = "";
            textBoxMail.Text = "";
            textBoxCp.Text = "";
            textBoxComm.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem objet = listView1.SelectedItems[0];
                textBoxVille.Text = objet.SubItems[1].Text;
                textBoxAdresse.Text = objet.SubItems[2].Text;
                maskedTextBoxTel.Text = objet.SubItems[3].Text;
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

        private void listViewPlein()
        {
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
        private void FormSite_Load(object sender, EventArgs e)
        {
            listViewPlein();
            
        }

        private void ajouter()
        {
            string Ville = textBoxVille.Text;
            string Adresse = textBoxAdresse.Text;
            string Téléphone = maskedTextBoxTel.Text;
            string Mail = textBoxMail.Text;
            string CodePostal = textBoxCp.Text;
            string Commentaire = textBoxComm.Text; 
            cn.Open();
            cmd.CommandText = "INSERT INTO SITES VALUES (@Ville, @Adresse, @Téléphone, @Mail, @Code postal, @Commentaire)";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@Ville", Ville);
            cmd.Parameters.AddWithValue("@Adresse", Adresse);
            cmd.Parameters.AddWithValue("@Téléphone", Téléphone);
            cmd.Parameters.AddWithValue("@Mail", Mail);
            cmd.Parameters.AddWithValue("@Code postal", CodePostal);
            cmd.Parameters.AddWithValue("@Commentaire", Commentaire);
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        private void Supprimer()
        {
            string ville = textBoxVille.Text;
            string Adresse = textBoxAdresse.Text;
            int Téléphone = int.Parse(maskedTextBoxTel.Text);
            string CodePostal = textBoxCp.Text;
            string Commentaire = textBoxComm.Text; 
            cn.Open();
            cmd.CommandText = "Delete From SITES VALUES ";
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            q = 1;
            reactiverBox();
            viderBox();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            switch (q)
            {
                case 1:
                    ajouter();
                    listViewPlein();   


                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:

                    break;
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            q = 3;
            modifierBoutton();
            Supprimer();
        }
    }
}
