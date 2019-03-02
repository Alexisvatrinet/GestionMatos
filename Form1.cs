using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient fabout = new FormClient();
            fabout.ShowDialog();
        }
        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPropos fabout = new FormPropos();
            fabout.ShowDialog();
        }
    }
}
