using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteJRapp
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientRegister fmr = new FormClientRegister();  
            fmr.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductRegister fmr = new FormProductRegister();
            fmr.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchClient fmr = new FormSearchClient();
            fmr.ShowDialog();
        }
    }
}
