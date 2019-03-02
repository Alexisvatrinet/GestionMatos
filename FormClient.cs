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
using System.Data.SqlClient;

namespace PPE2
{

    public partial class FormClient : Form
    {
        int q = 0;
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
            textBoxTelephone.Text = "";
            
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

        private void AjouterProduct()
        {
           
        }

        private void textBoxTelephone_TextChanged(object sender, EventArgs e)
        {
            //Regex regex = new Regex(@"[0-9]");
           // MatchCollection matches = regex.Matches(textBoxTelephone);
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
