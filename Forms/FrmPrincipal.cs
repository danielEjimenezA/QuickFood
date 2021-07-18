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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPlatoCRUD frmph = new FrmPlatoCRUD();
            frmph.Show();
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente fr = new FormCliente();
            fr.Show();
        }

        private void crearPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedido frm = new FormPedido();
            frm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidoHistory frmph = new FrmPedidoHistory();
            frmph.Show();
        }

        private void meseroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMeseroCRUD frmmmc = new FrmMeseroCRUD();
            frmmmc.Show();
        }

        private void platoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlatoCRUD frmpc = new FrmPlatoCRUD();
            frmpc.Show();
        }
    }
}
