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
    public partial class FrmMeseroCRUD : Form
    {
        private Mesero clsMesero = new Mesero();

        private static int idMesero = 0;
        
        
        public FrmMeseroCRUD()
        {
            InitializeComponent();
        }

        private void FrmMeseroCRUD_Load(object sender, EventArgs e)
        {
            toListMeseros();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            createMesero();
            toListMeseros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            idMesero = 0;
            toListMeseros();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idMesero!=0)
            {
                Datos.mesero selectMesero = new Datos.mesero();
                selectMesero.msrId = idMesero;
                selectMesero.msrIdentificacion = txtIdentificacion.Text;
                selectMesero.msrNombre = txtNombre.Text;

                clsMesero.update(selectMesero);
                toListMeseros();
                MessageBox.Show("Mesero actualizado correctamente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idMesero != 0)
            {
                clsMesero.delete(idMesero);
                toListMeseros();
                MessageBox.Show("Mesero eliminado correctamente");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    idMesero = int.Parse(row.Cells[0].Value.ToString());
                    obtener(idMesero);
                }
            }
        }

        public void toListMeseros()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = clsMesero.toList();
        }

        public void createMesero()
        {
            Datos.mesero newMesero = new Datos.mesero();
            newMesero.msrIdentificacion = txtIdentificacion.Text;
            newMesero.msrNombre = txtNombre.Text;

            clsMesero.create(newMesero);
            MessageBox.Show("Mesero ingresado correctamente");
        }

        public void obtener(int id)
        {
            Datos.mesero meseroSelect = clsMesero.obtener(id);
            txtIdentificacion.Text = meseroSelect.msrIdentificacion;
            txtNombre.Text = meseroSelect.msrNombre;
        }
    }
}
