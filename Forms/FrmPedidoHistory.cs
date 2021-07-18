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
        private Pedido clsPedido = new Pedido();
        private Cliente clsCliente = new Cliente();
        private Mesero clsMesero = new Mesero();

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

                listarClientes();
            }
        }

        private void rbtMesero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMesero.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;

                listarMeseros();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (rbtFecha.Checked)
            {
                foreach(pedido ped in clsPedido.listarPorFecha(dateTimePicker1.Value.Date))
                {
                    dataGridView1.Rows.Insert(i, ped.cliente.cltNombre,ped.mesero.msrNombre,ped.pddFecha,ped.pddTotal,ped.pddEstado);
                    i++;
                }
            } else if (rbtCliente.Checked)
            {
                foreach (pedido ped in clsPedido.listarPorCliente(cbxCliente.Text))
                {
                    dataGridView1.Rows.Insert(i, ped.cliente.cltNombre, ped.mesero.msrNombre, ped.pddFecha, ped.pddTotal, ped.pddEstado);
                    i++;
                }
            } else if (rbtMesero.Checked)
            {
                foreach (pedido ped in clsPedido.listarPorMesero(cbxMesero.Text))
                {
                    dataGridView1.Rows.Insert(i, ped.cliente.cltNombre, ped.mesero.msrNombre, ped.pddFecha, ped.pddTotal, ped.pddEstado);
                    i++;
                }
            }
        }

        public void listarClientes()
        {
            cbxCliente.Items.Clear();
            List<String> nombres = new List<string>();
            foreach (cliente cli in clsCliente.toList())
            {
                cbxCliente.Items.Add(cli.cltNombre);
            }

            //cbxCliente.DataSource = nombres;
        }

        public void listarMeseros()
        {
            cbxMesero.Items.Clear();
            List<String> nombres = new List<string>();
            foreach (mesero mese in clsMesero.toList())
            {
                cbxMesero.Items.Add(mese.msrNombre);
            }
            //cbxMesero.DataSource = nombres;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            rbtFecha.Checked = false;
            rbtCliente.Checked = false;
            rbtMesero.Checked = false;
        }
    }
}
