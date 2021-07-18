using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickFood.Modelo;
using QuickFood.Datos;

namespace QuickFood.Forms
{
    public partial class FrmPlatoCRUD : Form
    {
        private Plato clsPlato = new Plato();

        private static int idPlato = 0;

        public FrmPlatoCRUD()
        {
            InitializeComponent();
        }

        private void FrmPlatoCRUD_Load(object sender, EventArgs e)
        {
            toListPlatos();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            createPlato();
            toListPlatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cbxEstado.Text = "";
            idPlato = 0;
            toListPlatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idPlato != 0)
            {
                plato selectPlato = new plato();
                selectPlato.pltId = idPlato;
                selectPlato.pltDescripcion = txtDescripcion.Text;
                selectPlato.pltPrecio = decimal.Parse(txtPrecio.Text);
               
                clsPlato.update(selectPlato);
                toListPlatos();
                MessageBox.Show("Plato actualizado correctamente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPlato != 0)
            {
                clsPlato.delete(idPlato);
                toListPlatos();
                MessageBox.Show("Plato eliminado correctamente");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    idPlato = int.Parse(row.Cells[0].Value.ToString());
                    obtener(idPlato);
                }
            }
        }

        public void toListPlatos()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = clsPlato.toList();
        }

        public void createPlato()
        {
            plato newPlato = new plato();
            newPlato.pltDescripcion = txtDescripcion.Text;
            newPlato.pltPrecio = decimal.Parse(txtPrecio.Text);
            

            clsPlato.create(newPlato);
            MessageBox.Show("Plato ingresado correctamente");
        }

        public void obtener(int id)
        {
            plato platoSelect = clsPlato.obtener(id);
            txtDescripcion.Text = platoSelect.pltDescripcion;
            txtPrecio.Text = platoSelect.pltPrecio.ToString();
           
        }
    }
}
