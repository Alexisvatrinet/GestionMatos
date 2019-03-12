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
        public FormIntervention()
        {
            InitializeComponent();
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
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem objet = listView1.SelectedItems[0];
                textBoxComm.Text = objet.SubItems[2].Text;
                textBoxEtat.Text = objet.SubItems[0].Text;
                maskedTextBoxPlan.Text = objet.SubItems[1].Text;
            }
        }
    }
}
