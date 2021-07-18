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
    public partial class FormCocina : Form
    {

        pedido pe = new pedido();
        quickfoodDataContext db = new quickfoodDataContext();
        int pedidoId = 0;
        public FormCocina()
        {
            InitializeComponent();
            mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pedidoId != 0)
            {
                pe = db.pedido.First(z => z.pddId == pedidoId);
                pe.pddEstado = "DESPACHADO";
                db.SubmitChanges();
                dataGridView2.DataSource = null;
                mostrar();
                MessageBox.Show("Pedido Despachado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Elija un pedido.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void mostrar()
        {
            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource =  db.pedido.Where(x => x.pddEstado.Equals("PENDIENTE"));

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    pedidoId = int.Parse(row.Cells[0].Value.ToString());
                    obtener(pedidoId);
                }
            }
        }

        public void obtener(int id)
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = db.pedidodetalle.Where(z => z.pddId == id);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pedidoId != 0)
            {
                pe = db.pedido.First(z => z.pddId == pedidoId);
                pe.pddEstado = "CANCELADO";
                db.SubmitChanges();
                dataGridView2.DataSource = null;
                mostrar();
                MessageBox.Show("Pedido cancelado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Elija un pedido.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
