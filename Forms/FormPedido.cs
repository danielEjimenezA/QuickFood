using QuickFood.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickFood.Forms
{
    public partial class FormPedido : Form
    {

        quickfoodDataContext db = new quickfoodDataContext();
        List<pedidodetalle> listaPedidosDetalleMemoria = new List<pedidodetalle>();
        public FormPedido()
        {
            InitializeComponent();
            var clientes = db.cliente.ToArray();
            comboBox2.DataSource = clientes;
            comboBox2.DisplayMember = "cltNombre";
            comboBox2.ValueMember = "cltId";

            var meseros = db.mesero.ToArray();
            comboBox1.DataSource = meseros;
            comboBox1.DisplayMember = "msrNombre";
            comboBox1.ValueMember = "msrId";

            var platos = db.plato.ToArray();
            comboBox3.DataSource = platos;
            comboBox3.DisplayMember = "pltDescripcion";
            comboBox3.ValueMember = "pltId";

        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pedidodetalle p = new pedidodetalle();
            p.pdeDescripcion = textBox2.Text;
            p.plato = (plato)comboBox3.SelectedItem;
            p.pdeCantidad = int.Parse(textBox1.Text);

            listaPedidosDetalleMemoria.Add(p);

            mostrarDetalle();
        }

        public void mostrarDetalle()
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = listaPedidosDetalleMemoria;
            dataGridView1.Visible = true;
        }
    }
}
