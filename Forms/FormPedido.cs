using QuickFood.Datos;
using QuickFood.Modelo;
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
            if (textBox1.Text.Equals("") || textBox1.Text == null || comboBox3.SelectedItem == null )
            {
                MessageBox.Show("Campos requeridos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                plato pl = (plato)comboBox3.SelectedItem;
                pedidodetalle p = new pedidodetalle();
                p.pdeCantidad = int.Parse(textBox1.Text);
                p.pdeDescripcion = pl.pltDescripcion;
                p.pdeTotalDetalle = pl.pltPrecio * p.pdeCantidad;
                p.plato = pl;
                listaPedidosDetalleMemoria.Add(p);
                mostrarDetalle();
                MessageBox.Show("Detalle Agregado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        public void mostrarDetalle()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPedidosDetalleMemoria;
        }

        public void limpiar()
        {
            listaPedidosDetalleMemoria.Clear();
            mostrarDetalle();
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                decimal? valorT = 0;
                foreach (pedidodetalle itm in listaPedidosDetalleMemoria)
                {
                    valorT = valorT + itm.pdeTotalDetalle;
                }
                pedido pedido = new pedido();
                pedido.cliente = (cliente)comboBox2.SelectedItem;
                pedido.mesero = (mesero)comboBox1.SelectedItem;
                pedido.pddFecha = DateTime.Now;
                pedido.pddEstado = "PENDIENTE";
                pedido.pddTotal = valorT;

                db.pedido.InsertOnSubmit(pedido);

                db.SubmitChanges();

                pedido pedidoGuardado = db.pedido.First(x => x.pddId == pedido.pddId);

                foreach (pedidodetalle itm in listaPedidosDetalleMemoria)
                {
                    itm.pddId = pedidoGuardado.pddId;

                }

                db.SubmitChanges();

                limpiar();

                MessageBox.Show("Pedido Realizado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("El pedido fallo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}
