using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Data.SqlClient;

namespace PPE2
{
    public partial class FormClient : Form
    {

        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;


        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress test = new MailAddress(textBoxMail.Text);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        int q = 0;
        private object cnSQL;

        public FormClient()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            q = 1;
            textBoxNom.Text = "";
            textBoxAdresse.Text = "";
            textBoxMail.Text = "";
            maskedTextBox1.Text = "";
            
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            switch (q)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:
                    
                    break;
            }
        }

        private void textBoxTelephone_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            //textBoxMail = 
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            cn.Open();
            cmd.CommandText = "SELECT * FROM Client";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lvi = new ListViewItem(dr["nom"].ToString());
                lvi.SubItems.Add(dr["id"].ToString());
                lvi.SubItems.Add(dr["telephone"].ToString());
                lvi.SubItems.Add(dr["mail"].ToString());
                lvi.SubItems.Add(dr["adresse"].ToString());
                listViewClient.Items.Add(lvi);
            }
            cn.Close();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count > 0)
            {
                ListViewItem objet = listViewClient.SelectedItems[0];
                textBoxAdresse.Text = objet.SubItems[4].Text;
                textBoxNom.Text = objet.SubItems[0].Text;
                textBoxMail.Text = objet.SubItems[3].Text;
                maskedTextBox1.Text = objet.SubItems[2].Text;
                
            }
        }
    }
}
