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
using QuickFood.Modelo;

namespace QuickFood.Forms
{
    public partial class FrmPedidoHistory : Form
    {
        
        public FrmPedidoHistory()
        {
            InitializeComponent();
        }

        private void FrmPedidoHistory_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void rbtFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFecha.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCliente.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
            }
        }

        private void rbtMesero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMesero.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbtFecha.Checked)
            {

            } else if (rbtCliente.Checked)
            {

            } else if (rbtMesero.Checked)
            {

            }
        }
    }
}
