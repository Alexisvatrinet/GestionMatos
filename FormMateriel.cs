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

        private void demodifierBoutton()
        {
            buttonAjouter.Enabled = true;
            buttonModifier.Enabled = true;
            buttonSupprimer.Enabled = true;
            buttonValider.Enabled = false;
            buttonCancel.Enabled = false;
        }

        private void viderBox()
        {
            textBoxNom.Text = "";
            textBoxSite.Text = "";
            textBoxMail.Text = "";
            textBoxMtbf.Text = "";
            comboBoxClient.Text = "";
            comboBoxCat.Text = "";
            textBoxDesc.Text = "";
            textBoxIdCat.Text = "";
        }

        private void desactiverBox()
        {
            textBoxNom.Enabled = false;
            textBoxSite.Enabled = false;
            textBoxMtbf.Enabled = false;
            comboBoxClient.Enabled = false;
            textBoxMail.Enabled = false;
            textBoxDesc.Enabled = false;
            textBoxIdClient.Enabled = false;
            buttonCancel.Enabled = false;
            buttonValider.Enabled = false;
            comboBoxCat.Enabled = false;
        }

            private void FormMateriel_Load(object sender, EventArgs e)
        {
            desactiverBox();
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "SELECT * FROM Materiel";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lvi = new ListViewItem(dr["nom"].ToString());
                lvi.SubItems.Add(dr["id"].ToString());
                lvi.SubItems.Add(dr["site"].ToString());
                lvi.SubItems.Add(dr["mtbf"].ToString());
                lvi.SubItems.Add(dr["description"].ToString());
                lvi.SubItems.Add(dr["id_Client"].ToString());
                lvi.SubItems.Add(dr["id_Constructeur"].ToString());
                lvi.SubItems.Add(dr["id_Categorie"].ToString());
                listView1.Items.Add(lvi);
            }
            cn.Close();
            cn.Open();
            cmd.CommandText = "SELECT id, objet FROM categorie";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string combo = dr.GetString(1);
                comboBoxCat.Items.Add(combo);
            }
            cn.Close();
            cn.Open();
            cmd.CommandText = "SELECT id, nom FROM Client";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string combo = dr.GetString(1);
                comboBoxClient.Items.Add(combo);
            }
            cn.Close();
            cn.Open();
            cmd.CommandText = "SELECT id, marque FROM constructeur";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string combo = dr.GetString(1);
                comboBoxConst.Items.Add(combo);
            }
            cn.Close();

        }

        private void ajouter()
        {
            string nom = textBoxNom.Text;
            string site = textBoxSite.Text;
            string desc = textBoxDesc.Text;
            int mtbf = int.Parse(textBoxMtbf.Text);
            int id_cat = int.Parse(textBoxIdCat.Text);
            int id_client = int.Parse(textBoxIdClient.Text);
            int id_const = int.Parse(textBoxIdConst.Text);
            cn.Open();
            cmd.CommandText = "INSERT INTO Materiel ([nom],[site],[mtbf],[description],[id_Client],[id_Constructeur],[id_Categorie]) VALUES (@nom, @site, @mtbf, @desc, @id_Client, @id_Constructeur, @id_Categorie)";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@site", site);
            cmd.Parameters.AddWithValue("@mtbf", mtbf);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@id_Client", id_client);
            cmd.Parameters.AddWithValue("@id_Constructeur", id_const);
            cmd.Parameters.AddWithValue("@id_Categorie", id_cat);
            cn.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 )
            {
                ListViewItem objet = listView1.SelectedItems[0];
                textBoxNom.Text = objet.SubItems[0].Text;
                textBoxSite.Text = objet.SubItems[2].Text;
                textBoxMtbf.Text = objet.SubItems[3].Text;
                textBoxDesc.Text = objet.SubItems[4].Text;
                textBoxIdClient.Text = objet.SubItems[5].Text;
                textBoxIdConst.Text = objet.SubItems[6].Text;
                textBoxIdCat.Text = objet.SubItems[7].Text;
                int idutil = int.Parse(textBoxIdClient.Text);
                string categorie = comboBoxCat.Text;
                cn.Close();
                cn.Open();
                int idClient = int.Parse(textBoxIdClient.Text);
                cmd.CommandText = "SELECT nom FROM client WHERE id = @idclient";
                cmd.Parameters.AddWithValue("@idclient", idClient);
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string categorieId = dr.GetString(0);
                    textBoxIdCat.Text = categorieId.ToString();
                }
                cn.Close();
                int idcat = int.Parse(textBoxIdCat.Text);
                cn.Open();
                cmd.CommandText = "SELECT objet FROM categorie WHERE id =" + idcat;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxCat.Text = dr.GetValue(0).ToString();
                }
                cn.Close();
                int idconst = int.Parse(textBoxIdConst.Text);
                cn.Open();
                cmd.CommandText = "SELECT marque FROM constructeur WHERE id =" + idconst;
                dr = cmd.ExecuteReader();
                cmd.Connection = cn;
                while (dr.Read())
                {
                    comboBoxConst.Text = dr.GetValue(0).ToString();
                }
                cn.Close();
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            demodifierBoutton();
            comboBoxCat.Text = "autre";
            switch (q)
            {
                case 1:
                    ajouter();
                    break;
                default:
                    break;       
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            q = 1;
            modifierBoutton();
            viderBox();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            demodifierBoutton();
            viderBox();
        }

        private void comboBoxConst_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categorie = comboBoxCat.Text;
            cn.Close();
            cn.Open();
            cmd.CommandText = "SELECT id FROM categorie WHERE objet = @categorie";
            cmd.Parameters.AddWithValue("@categorie", categorie);
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int categorieId = dr.GetInt32(0);
                textBoxIdCat.Text = categorieId.ToString() ;
            }
            cn.Close();
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string client = comboBoxClient.Text;
            cn.Close();
            cn.Open();
            cmd.CommandText = "SELECT id FROM client WHERE nom = @client";
            cmd.Parameters.AddWithValue("@client", client);
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //getInt32 pour les int de la base de données
                int clientId = dr.GetInt32(0);
                textBoxIdClient.Text = clientId.ToString();
            }
            cn.Close();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
