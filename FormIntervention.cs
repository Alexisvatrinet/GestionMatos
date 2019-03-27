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
    public partial class FormIntervention : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public int id_int;
        public int id_client;

        public FormIntervention()
        {
            InitializeComponent();
        }

        private void desactiverBox()
        {
            textBoxAdresse.Enabled = false;
            textBoxComm.Enabled = false;
            textBoxTelephone.Enabled = false;
            textBoxClient.Enabled = false;
            textBoxMail.Enabled = false;
            textBoxEtat.Enabled = false;
            maskedTextBoxPlan.Enabled = false;
            buttonValider.Enabled = false;
            buttonCancel.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
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

        private void viderBox()
        {
            textBoxAdresse.Text = "";
            textBoxComm.Text = "";
            textBoxTelephone.Text = "";
            textBoxClient.Text = "";
            textBoxMail.Text = "";
            textBoxEtat.Text = "";
            maskedTextBoxPlan.Text = "";
        }

        private void combo()
        {
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
        }
        
        private void client()
        {
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "SELECT id_client FROM materiel WHERE id_intervention = " + id_int;
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id_client = int.Parse(dr[0].ToString());
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
            cn.Close();
            cmd.CommandText = "ALTER TABLE materiel ALTER COLUMN id_intervention WHERE ";
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
            desactiverBox();
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
            }
        }
    }
}
