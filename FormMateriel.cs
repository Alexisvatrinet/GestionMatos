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
using System.Net.Mail;

namespace PPE2
{
    public partial class FormMateriel : Form
    {
        private int id_mat;
        private int id_client;
        private int q = 0;
        private string testMail;
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private MailAddress ma;

        public FormMateriel()
        {
            InitializeComponent();
        }
        //Les fonctions du code
        private void modifierBoutton()
        {
            buttonAjouter.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonInt.Enabled = false;
            buttonValider.Enabled = true;
            buttonCancel.Enabled = true;
        }

        private void demodifierBoutton()
        {
            buttonAjouter.Enabled = true;
            buttonModifier.Enabled = true;
            buttonSupprimer.Enabled = true;
            buttonInt.Enabled = true;
            buttonValider.Enabled = false;
            buttonCancel.Enabled = false;
        }

        private void viderBox()
        {
            textBoxNom.Text = "";
            textBoxSite.Text = "";
            textBoxMail.Text = "";
            textBoxMtbf.Text = "";
            textBoxDesc.Text = "";
            textBoxIdCat.Text = "";
            textBoxIdConst.Text = "";
            textBoxIdClient.Text = "";
            textBoxClient.Text = "";
            textBoxCat.Text = "";
            textBoxConst.Text = "";
            textBoxInt.Text = "";

            comboBoxClient.Text = "";
            comboBoxCat.Text = "";
            comboBoxConst.Text = "";
        }

        private void desactiverBox()
        {
            textBoxNom.Enabled = false;
            textBoxSite.Enabled = false;
            textBoxMtbf.Enabled = false;
            textBoxMail.Enabled = false;
            textBoxDesc.Enabled = false;
            textBoxIdClient.Enabled = false;
            textBoxConst.Enabled = false;
            textBoxCat.Enabled = false;
            textBoxClient.Enabled = false;
            buttonCancel.Enabled = false;
            buttonValider.Enabled = false;
            comboBoxCat.Enabled = false;
            comboBoxConst.Enabled = false;
            comboBoxClient.Enabled = false;

            textBoxCat.Visible = true;
            textBoxConst.Visible = true;
            textBoxClient.Visible = true;
            comboBoxCat.Visible = false;
            comboBoxConst.Visible = false;
            comboBoxClient.Visible = false;
        }

        private void activerBox()
        {
            textBoxNom.Enabled = true;
            textBoxSite.Enabled = true;
            textBoxMtbf.Enabled = true;
            textBoxMail.Enabled = true;
            textBoxDesc.Enabled = true;
            textBoxCat.Enabled = false;
            textBoxClient.Enabled = false;
            textBoxConst.Enabled = false;
            buttonCancel.Enabled = true;
            buttonValider.Enabled = true;
            comboBoxCat.Enabled = true;
            comboBoxConst.Enabled = true;
            comboBoxClient.Enabled = true;

            textBoxCat.Visible = false;
            textBoxClient.Visible = false;
            textBoxConst.Visible = false;
            comboBoxCat.Visible = true;
            comboBoxClient.Visible = true;
            comboBoxConst.Visible = true;
        }

        private void testBox()
        {
            if (textBoxNom.Text == "" || textBoxDesc.Text == "" || textBoxMtbf.Text == "" || textBoxDesc.Text == "" || textBoxIdCat.Text == "" || textBoxIdConst.Text == "")
            {
                buttonValider.Enabled = false;
                if (q != 0)
                {
                    labelValider.Text = "Veuillez remplir toutes les champs pour activer ce boutton";
                }
                else
                {
                    labelValider.Text = "";
                }
            }
            else if (textBoxNom.Text != "" && textBoxDesc.Text != "" && textBoxMtbf.Text != "" && textBoxDesc.Text != "" && textBoxIdCat.Text != "" && textBoxIdConst.Text != "")
            {
                buttonValider.Enabled = true;
                labelValider.Text = "";
            }
        }

        private void comboText()
        {
            comboBoxCat.Text = textBoxCat.Text;
            comboBoxClient.Text = textBoxClient.Text;
            comboBoxConst.Text = textBoxConst.Text;
        }

        private void listViewPlein()
        {
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
                lvi.SubItems.Add(dr["id_Intervention"].ToString());
                listView1.Items.Add(lvi);
            }
            cn.Close();
        }

        private void comboPlein()
        {

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
            cmd.CommandText = "SELECT id, nom from client order by id";
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
            try 
            {
                ma = new MailAddress(textBoxMail.Text);
                testMail = "bon";
            }
            catch(FormatException)
            {
                testMail = "pasbon";
            }
            if(testMail == "bon")
            {
            string nom = textBoxNom.Text;
            string site = textBoxSite.Text;
            string desc = textBoxDesc.Text;
            string client = comboBoxClient.Text;
            int mtbf = int.Parse(textBoxMtbf.Text);
            int id_cat = int.Parse(textBoxIdCat.Text);
            int id_const = int.Parse(textBoxIdConst.Text);
            int id_client = int.Parse(textBoxIdClient.Text);
            cn.Open();
            cmd.CommandText = "INSERT INTO Materiel ([nom],[site],[mtbf],[description],[id_Client],[id_Constructeur],[id_Categorie]) VALUES (@nom, @site, @mtbf, @desc, @id_Client, @id_Constructeur, @id_Categorie)";
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@site", site);
            cmd.Parameters.AddWithValue("@mtbf", mtbf);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@id_Client", id_client);
            cmd.Parameters.AddWithValue("@id_Constructeur", id_const);
            cmd.Parameters.AddWithValue("@id_Categorie",id_cat);
            cmd.ExecuteNonQuery();
            cn.Close();
            }
            else
            {
                labelFaux.Text = "L'adresse email entrée n'est pas valide: votre requête n'a pas été executée";
                q = 0;
            }
        }

        private void modifier()
        {
            try
            {
                ma = new MailAddress(textBoxMail.Text);
                testMail = "bon";
            }
            catch (FormatException)
            {
                testMail = "pasbon";
            }
            if (testMail == "bon")
            {
                cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
                cmd = new SqlCommand();
                string nom = textBoxNom.Text;
                string site = textBoxSite.Text;
                string desc = textBoxDesc.Text;
                int id_client = int.Parse(textBoxIdClient.Text);
                int id_cat = int.Parse(textBoxIdCat.Text);
                int id_const = int.Parse(textBoxIdConst.Text);
                int mtbf = int.Parse(textBoxMtbf.Text);
                cn.Open();
                cmd.CommandText = "UPDATE Materiel SET nom = @nom,site = @site,mtbf = @mtbf,description = @desc,id_client = @id_client,id_constructeur = @id_const, id_categorie = @id_cat WHERE id = @id";
                cmd.Connection = cn;
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@site", site);
                cmd.Parameters.AddWithValue("@mtbf", mtbf);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@id_client", id_client);
                cmd.Parameters.AddWithValue("@id_cat", id_cat);
                cmd.Parameters.AddWithValue("@id_const", id_const);
                cmd.Parameters.AddWithValue("@id", id_mat);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            else
            {
                q = 0;
                labelFaux.Text = "L'adresse email n'est pas conforme votre requête n'a pas été éxecuté";
            }
        }

        private void supprimer()
        {
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "DELETE FROM Materiel WHERE id = " + id_mat;
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void client()
        {
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "SELECT id_client FROM materiel WHERE id = @id_mat";
            cmd.Parameters.AddWithValue("@id_mat", id_mat);
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id_client = int.Parse(dr[0].ToString());
            }
            cn.Close();
            cn.Open();
            cmd.CommandText = "SELECT * FROM client WHERE id = @id_client";
            cmd.Parameters.AddWithValue("@id_client", id_client);
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxClient.Text = dr["nom"].ToString();
                textBoxMail.Text = dr["mail"].ToString();
            }
            cn.Close();
        }
        //----------------------------------------------------------------------------------
        //Au debut de la page je desactive ceratine box et bouton je rempli ma listView 
        //et mes comboBox avec la base de données
        private void FormMateriel_Load(object sender, EventArgs e)
        {
            desactiverBox(); 
            listViewPlein();
            comboPlein();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem objet = listView1.SelectedItems[0];
                textBoxNom.Text = objet.SubItems[0].Text;
                id_mat = int.Parse(objet.SubItems[1].Text);
                textBoxSite.Text = objet.SubItems[2].Text;
                textBoxMtbf.Text = objet.SubItems[3].Text;
                textBoxDesc.Text = objet.SubItems[4].Text;
                textBoxIdClient.Text = objet.SubItems[5].Text;
                textBoxIdConst.Text = objet.SubItems[6].Text;
                textBoxIdCat.Text = objet.SubItems[7].Text;
                textBoxIdInt.Text = objet.SubItems[8].Text;
                int idutil = int.Parse(textBoxIdClient.Text);
                string categorie = comboBoxCat.Text;
                cn.Close();
                cn.Open();
                int idClient = int.Parse(textBoxIdClient.Text);
                cmd.CommandText = "SELECT id, nom FROM client WHERE id = " +idClient;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
                while ((dr.IsClosed == false) && (dr.Read()))
                {
                    int categorieId = dr.GetInt32(0);
                    //textBoxIdCat.Text = categorieId.ToString();
                }
                cn.Close();
                int idcat = int.Parse(textBoxIdCat.Text);
                cn.Open();
                cmd.CommandText = "SELECT id, objet FROM categorie WHERE id =" + idcat;
                cmd.Connection = cn;
                dr = cmd.ExecuteReader();
                while ((dr.IsClosed == false) && (dr.Read()))
                {
                    textBoxCat.Text = dr[0].ToString();
                }
                cn.Close();
                int idconst = int.Parse(textBoxIdConst.Text);
                cn.Open();
                cmd.CommandText = "SELECT marque FROM constructeur WHERE id =" + idconst;
                dr = cmd.ExecuteReader();
                while ((dr.IsClosed == false) && (dr.Read()))
                {
                    textBoxConst.Text = dr[0].ToString();
                }
                cn.Close();
                textBoxInt.Text = "Pas d'intervention planifiée";
                if (textBoxIdInt.Text != "")
                {
                    int idInt = int.Parse(textBoxIdInt.Text);
                    cn.Open();
                    cmd.CommandText = "SELECT etat, planifie FROM intervention WHERE id = @idInt";
                    cmd.Parameters.AddWithValue("@idInt", idInt);
                    dr = cmd.ExecuteReader();
                    while ((dr.IsClosed == false) && (dr.Read()))
                    {
                        bool etat = Convert.ToBoolean(dr["etat"]);
                        if (Convert.ToBoolean(dr["etat"]) == false)
                        {
                            textBoxInt.Text = "Une intervention est planifiée";
                        }
                        else if (Convert.ToBoolean(dr["etat"]) == true)
                        {
                            textBoxInt.Text = "L'intervention à déjà été réalisée";
                        }
                    }
                    cn.Close();
                }
                client();
                buttonModifier.Enabled = true;
                buttonSupprimer.Enabled = true;
            }
        }
        //-----------------------------------------------------------
        // Partie des boutton
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            q = 1;
            modifierBoutton();
            activerBox();
            viderBox();
            comboText();
            buttonValider.Enabled = false;
            labelInt.Visible = false;
            textBoxInt.Visible = false;
            labelEtat.Text = "Cliquer sur VALIDER pour AJOUTER un objet à la liste";
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            q = 2;
            modifierBoutton();
            activerBox();
            comboText();
            labelInt.Visible = false;
            textBoxInt.Visible = false;
            labelEtat.Text = "Cliquer sur VALIDER pour MODIFIER l'objet: " + nom;
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            q = 3;
            modifierBoutton();
            listView1.Enabled = false;
            labelEtat.Text = "Cliquer sur VALIDER pour MODIFIER l'objet: " + nom;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            demodifierBoutton();
            comboBoxCat.Text = "autre";
            switch (q)
            {
                case 1:
                    ajouter();
                    listView1.Items.Clear();
                    listViewPlein();
                    label3.Text = "";
                    break;
                case 2:
                    modifier();
                    listView1.Items.Clear();
                    listViewPlein();
                    break;
                case 3:
                    supprimer();
                    listView1.Items.Clear();
                    listViewPlein();
                    viderBox();
                    break;
                default:
                    break;
            }
            demodifierBoutton();
            desactiverBox();
            viderBox();
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            listView1.Enabled = true;
            textBoxInt.Visible = true;
            labelInt.Visible = true;
            q = 0;
            labelValider.Text = "";
            labelEtat.Text = "";
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            demodifierBoutton();
            desactiverBox();
            viderBox();
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            listView1.Enabled = true;
            textBoxInt.Visible = true;
            labelInt.Visible = true;
            q =  0;
            labelValider.Text = "";
        }
        //---------------------------------------------------------------------
        // Permet de remplir des variables avec l'Id relié au nom dans la bdd
        private void comboBoxConst_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constructeur = comboBoxConst.Text;
            cn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT id FROM constructeur WHERE marque = @constructeur";
            cmd.Parameters.AddWithValue("@constructeur", constructeur);
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int constId = dr.GetInt32(0);
                textBoxIdConst.Text = constId.ToString();
            }
            cn.Close();
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string client = comboBoxClient.Text;
            cn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT id FROM client WHERE nom = @client";
            cmd.Parameters.AddWithValue("@client", client);
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int clientId = dr.GetInt32(0);
                textBoxIdClient.Text = clientId.ToString();
            }
            cn.Close();
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cat = comboBoxCat.Text;
            cn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT id FROM categorie WHERE objet = @cat";
            cmd.Parameters.AddWithValue("@cat", cat);
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int catId = dr.GetInt32(0);
                textBoxIdCat.Text = catId.ToString();
            }
            cn.Close();
        }
        // Suite de test pour voir si tout les chemps on bien été remplis
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (q != 0)
            {
                testBox();
            }
        }

        private void textBoxSite_TextChanged(object sender, EventArgs e)
        {
            if (q != 0)
            {
                testBox();
            }
        }

        private void textBoxMtbf_TextChanged(object sender, EventArgs e)
        {
            if (q != 0)
            {
                testBox();
            }
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            if (q != 0)
            {
                testBox();
            }
        }

        private void textBoxIdClient_TextChanged(object sender, EventArgs e)
        {
            if (q != 0)
            {
                testBox();
            }
        }

        private void textBoxIdCat_TextChanged(object sender, EventArgs e)
        {
            if (q != 0)
            {
                testBox();
            }
        }

        private void textBoxIdConst_TextChanged(object sender, EventArgs e)
        {
            if (q != 0)
            {
                testBox();
            }
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            if (q != 0)
            {
                testBox();
            }
        }
    }
}
