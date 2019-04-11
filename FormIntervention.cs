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
using System.Collections;
using System.Text.RegularExpressions;

namespace PPE2
{
    public partial class FormIntervention : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private int id_int;
        private int id_client;
        private int q;
        private int id_objet;
        private string date_int;
        private string nom_Objet;
        private string hiddenValue;
        private string displayValue;
        Regex regex = new Regex(@"^\d$");

        public FormIntervention()
        {
            InitializeComponent();
        }

        private void activerBox()
        {
            comboBoxObjet.Enabled = true;
            maskedTextBoxPlan.Enabled = true;
            textBoxEtat.Enabled = true;
            textBoxComm.Enabled = true;
            
            comboBoxObjet.Visible = true;
        }

        private void desactiverBox()
        {
            textBoxAdresse.Enabled = false;
            textBoxComm.Enabled = false;
            textBoxTelephone.Enabled = false;
            textBoxMail.Enabled = false;
            textBoxEtat.Enabled = false;
            textBoxClient.Enabled = false;
            textBoxObjet.Enabled = false;
            maskedTextBoxPlan.Enabled = false;
            comboBoxObjet.Enabled = false;
            buttonValider.Enabled = false;
            buttonCancel.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            
            textBoxObjet.Visible = true;
            comboBoxObjet.Visible = false;

        }

        private void reactiverBox()
        {
            textBoxAdresse.Enabled = true;
            textBoxComm.Enabled = true;
            textBoxTelephone.Enabled = true;
            textBoxClient.Enabled = true;
            textBoxMail.Enabled = true;
            textBoxEtat.Enabled = true;
            maskedTextBoxPlan.Enabled = true;
            buttonValider.Enabled = true;
            buttonCancel.Enabled = true;
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonAjouter.Enabled = false;
            listView1.Enabled = false;
        }

        private void modifierBoutton()
        {
            buttonAjouter.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
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
            textBoxAdresse.Text = "";
            textBoxComm.Text = "";
            textBoxTelephone.Text = "";
            textBoxClient.Text = "";
            textBoxMail.Text = "";
            textBoxEtat.Text = "";
            textBoxObjet.Text = "";
            maskedTextBoxPlan.Text = "";
        }

        private void listViewPlein()
        {
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "SELECT * FROM Intervention WHERE etat = 0";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lvi = new ListViewItem(dr["planifie"].ToString());
                lvi.SubItems.Add(dr["etat"].ToString());
                lvi.SubItems.Add(dr["commentaire"].ToString());
                lvi.SubItems.Add(dr["id"].ToString());
                listView1.Items.Add(lvi);
            }
            cn.Close();
            cn.Open();
            cmd.CommandText = "SELECT * FROM Intervention WHERE etat = 1";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lvi = new ListViewItem(dr["planifie"].ToString());
                lvi.SubItems.Add(dr["etat"].ToString());
                lvi.SubItems.Add(dr["commentaire"].ToString());
                lvi.SubItems.Add(dr["id"].ToString());
                listView1.Items.Add(lvi);
            }
            cn.Close();
        }

        public class valueUtile
        {
            private string myShortName;
            private string myLongName;

            public valueUtile(string strLongName, string strShortName)
            {

                this.myShortName = strShortName;
                this.myLongName = strLongName;
            }

            public string id
            {
                get
                {
                    return myShortName;
                }
            }

            public string combo
            {

                get
                {
                    return myLongName;
                }
            }
        }

        private void combo()
        {
            ArrayList valueUtiles = new ArrayList();
            cn.Open();
            cmd.CommandText = "SELECT id, nom FROM materiel";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string combo = dr.GetString(1);
                string id = dr.GetInt32(0).ToString();
                valueUtiles.Add(new valueUtile(combo, id));
            }
            comboBoxObjet.DataSource = valueUtiles;
            comboBoxObjet.DisplayMember = "combo";
            comboBoxObjet.ValueMember = "id";
            cn.Close();
        }
        
        private void comboText()
        {
            comboBoxObjet.Text = textBoxObjet.Text;
        }

        private void bouttonDeRequete()
        {
            modifierBoutton();
            activerBox();
            comboText();
            textBoxObjet.Visible = false;
            textBoxClient.Enabled = false;
            textBoxObjet.Enabled = false;
            buttonValider.Enabled = false;
        }

        private void client()
        {
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "SELECT nom, id_client FROM materiel WHERE id_intervention = " + id_int;
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxObjet.Text = dr[0].ToString();
                id_client = int.Parse(dr[1].ToString());
            }
            cn.Close();
            cn.Open();
            cmd.CommandText = "SELECT * FROM client WHERE id = " + id_client;
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxClient.Text = dr["nom"].ToString();
                textBoxAdresse.Text = dr["adresse"].ToString();
                textBoxTelephone.Text = dr["telephone"].ToString();
                textBoxMail.Text = dr["mail"].ToString();
            }
            cn.Close();
        }

        private void objetFill()
        {
            cn.Open();
            cmd.CommandText = "SELECT id, nom FROM materiel WHERE id_intervention = " + id_int;
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxIdObjet.Text = dr[0].ToString();
                textBoxObjet.Text = dr[1].ToString();
            }
            cn.Close();
        }

        // permet de vérifier le texte des boites
        private void testBox()
        {
            if (comboBoxObjet.Text == "" || textBoxComm.Text == "" || maskedTextBoxPlan.Text == "")
            {
                buttonValider.Enabled = false;
                labelValider.Text = "Veuillez remplir toutes les chemps pour activer ce boutton";
            }
            else if (comboBoxObjet.Text != "" && textBoxComm.Text != "" && maskedTextBoxPlan.Text != "")
            {
                buttonValider.Enabled = true;
                labelValider.Text = "";
            }
        }

        private void ajouter()
        {
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            string plan = maskedTextBoxPlan.Text;
            string comm = textBoxComm.Text;
            cn.Open();
            cmd.CommandText = "INSERT INTO Intervention VALUES('@plan', '@comm', 0)";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@plan", plan);
            cmd.Parameters.AddWithValue("@comm", comm);
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Open();
            cmd.CommandText = "UPDATE TABLE materiel  ";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@id_int", id_int);
            cmd.Parameters.AddWithValue("@date_int", date_int);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        
        private void modifier()
        {
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            string plan = maskedTextBoxPlan.Text;
            string comm = textBoxComm.Text;
            cn.Open();
            cmd.CommandText = "UPDATE TABLE Intervention VALUES('@plan', '@comm', 0)";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@plan", plan);
            cmd.Parameters.AddWithValue("@comm", comm);
            cmd.ExecuteNonQuery();
            cn.Close();
            cmd.CommandText = "UPDATE TABLE materiel  ";
        }

        private void supprimer()
        {
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            int selectid = int.Parse(textBoxIdSelect.Text);
            cn.Open();
            cmd.CommandText = "UPDATE materiel SET date_intervention = null, id_intervention = null WHERE id_client =  @idclient";
            cmd.Parameters.AddWithValue("@idclient", selectid);
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            cn.Close();
            labelInfo.Text = "Cliquer sur valider pour retirer l'intervention de son objet. Vous ne pouvez pas supprimer une intervention sans passer par la base";
        }

        private void FormIntervention_Load(object sender, EventArgs e)
        {
            listViewPlein();
            desactiverBox();
            combo();
            textBoxIdObjet.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            viderBox();
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem objet = listView1.SelectedItems[0];
                textBoxComm.Text = objet.SubItems[2].Text;
                textBoxEtat.Text = objet.SubItems[1].Text;
                maskedTextBoxPlan.Text = objet.SubItems[0].Text;
                id_int = int.Parse(objet.SubItems[3].Text);
                client();
                objetFill();
                buttonModifier.Enabled = true;
                buttonSupprimer.Enabled = true;
            }
            else
            {
                buttonModifier.Enabled = false;
                buttonSupprimer.Enabled = false;
            }
        }

        private void textBoxIdClient_TextChanged(object sender, EventArgs e)
        {
            testBox();
        }

        private void textBoxEtat_TextChanged(object sender, EventArgs e)
        {
            testBox();
        }

        private void maskedTextBoxPlan_TextChanged(object sender, EventArgs e)
        {
            testBox();
        }
        
        private void textBoxComm_TextChanged(object sender, EventArgs e)
        {
            testBox();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            q = 1;
            comboBoxObjet.SelectedItem = -1;
            bouttonDeRequete();
            viderBox();
            label3.Text = "Ce champ est optionnel";
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            q = 2;
            bouttonDeRequete();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            q = 3;
            bouttonDeRequete();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            switch (q)
            {
                case 1:
                    ajouter();
                    break;
                case 2:
                    modifier();
                    break;
                case 3:
                    supprimer();
                    break;
            }
            q = 0;
            listView1.Items.Clear();
            listViewPlein();
            label3.Text = "";
            labelEtat.Text = "";
            labelValider.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            demodifierBoutton();
            q = 0;
            label3.Text = "";
            labelEtat.Text = "";
            labelValider.Text = "";
            viderBox();
            demodifierBoutton();
            desactiverBox();
        }

        private void comboBoxObjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIdObjet.Text = comboBoxObjet.SelectedValue.ToString();
            try 
            {
                regex = new Regex(textBoxIdObjet.Text);
                id_objet = int.Parse(textBoxIdObjet.Text);
;            }
            catch (FormatException) { }
            nom_Objet = comboBoxObjet.Text;
            cmd.Parameters.Clear();
            cn.Close();
            cn.Open();
            cmd.CommandText = "SELECT id_Client FROM Materiel WHERE id = @id_objet";
            cmd.Parameters.AddWithValue("@id_objet", id_objet);
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while ((dr.IsClosed == false) && (dr.Read()))
            {
                id_client = int.Parse(dr["id_client"].ToString());
            }
            cn.Close();
            cmd.Parameters.Clear();
            cn.Open();
            cmd.CommandText = "SELECT nom, adresse, telephone, mail FROM Client WHERE id = @id_util";
            cmd.Parameters.AddWithValue("@id_util", id_client);
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while ((dr.IsClosed == false) && dr.Read())
            {
                textBoxClient.Text = dr["nom"].ToString();
                textBoxAdresse.Text = dr["adresse"].ToString();
                textBoxTelephone.Text = dr["telephone"].ToString();
                textBoxMail.Text = dr["mail"].ToString();
            }
            cn.Close();
        }  
    }
}
