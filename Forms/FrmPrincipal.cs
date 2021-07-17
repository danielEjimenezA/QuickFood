using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickFood.Datos;
using QuickFood.Forms;

namespace QuickFood.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente fr = new FormCliente();
            fr.Show();
        }
    }
}
