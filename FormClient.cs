﻿using System;
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
        int q = 0;
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        private void desactiverBox()
        {
            textBoxAdresse.Enabled = false;
            textBoxMail.Enabled = false;
            textBoxMail.Enabled = false;
            maskedTextBoxTel.Enabled = false;
            buttonCancel.Enabled = false;
            buttonValider.Enabled = false;
        }

        private void reactiverBox()
        {
            textBoxAdresse.Enabled = true;
            textBoxMail.Enabled = true;
            textBoxMail.Enabled = true;
            maskedTextBoxTel.Enabled = true;
            buttonCancel.Enabled = true;
            buttonValider.Enabled = true;
            buttonSupprimer.Enabled = false;
            buttonAjouter.Enabled = false;
            buttonModifier.Enabled = false;
        }

        private void viderBox()
        {
            textBoxAdresse.Text = "";
            textBoxNom.Text = "";
            textBoxMail.Text = "";
            maskedTextBoxTel.Text = "";
        }

        private void listviewplein()
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

        private void ajouter()
        {
            cn = new SqlConnection(@"Server =.\SQLEXPRESS; Database = GestionMatos;  Integrated Security = SSPI; Connect Timeout = 5");
            cmd = new SqlCommand();
            string nom = textBoxNom.Text;
            string adresse = textBoxAdresse.Text;
            string mail = textBoxMail.Text;
            int numero = int.Parse(maskedTextBoxTel.Text);
            cn.Open();
            cmd.CommandText = "INSERT INTO Client VALUES (@nom, @adresse, @numero, @mail)";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public FormClient()
        {
            InitializeComponent();
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
                    listViewClient.Clear();
                    listviewplein();
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
            listviewplein();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count > 0)
            {
                ListViewItem objet = listViewClient.SelectedItems[0];
                textBoxAdresse.Text = objet.SubItems[4].Text;
                textBoxNom.Text = objet.SubItems[0].Text;
                textBoxMail.Text = objet.SubItems[3].Text;
                maskedTextBoxTel.Text = objet.SubItems[2].Text;
                
            }
        }
    }
}
