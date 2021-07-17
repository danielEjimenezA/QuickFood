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

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            FrmPlatoCRUD frmph = new FrmPlatoCRUD();
            frmph.Show();
=======
        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente fr = new FormCliente();
            fr.Show();
>>>>>>> 1348ff57058bd6c6d227273348718df68850919c
        }
    }
}
