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

namespace QuickFood.Forms
{
    public partial class FormCliente : Form
    {
        quickfoodDataContext db = new quickfoodDataContext();
        cliente cli = new cliente();
        int idCliente = 0;

        public FormCliente()
        {
            InitializeComponent();
            mostrar();
        }

        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            idCliente = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(idCliente == 0)
                {
                    cliente cli = new cliente();
                    cli.cltNombre = textBox1.Text;
                    cli.cltIdentificacion = textBox2.Text;
                    cli.cltDireccion = textBox3.Text;
                    cli.cltTelefono = textBox4.Text;
                    db.cliente.InsertOnSubmit(cli);
                    db.SubmitChanges();
                    limpiar();
                    mostrar();
                    MessageBox.Show("Se guardo correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cli.cltNombre = textBox1.Text;
                    cli.cltIdentificacion = textBox2.Text;
                    cli.cltDireccion = textBox3.Text;
                    cli.cltTelefono = textBox4.Text;
                    db.SubmitChanges();
                    limpiar();
                    mostrar();
                    MessageBox.Show("Se actualizo correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        public void mostrar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.cliente.ToArray();
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

        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !Char.IsSeparator(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void obtener(int id)
        {
            cli = db.cliente.First(x => x.cltId == id);

            textBox1.Text = cli.cltNombre;
            textBox2.Text = cli.cltIdentificacion;
            textBox3.Text = cli.cltDireccion;
            textBox4.Text = cli.cltTelefono;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    idCliente = int.Parse(row.Cells[0].Value.ToString());
                    obtener(idCliente);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idCliente != 0)
            {
                obtener(idCliente);
                db.cliente.DeleteOnSubmit(cli);
                db.SubmitChanges();
                mostrar();
                limpiar();
                MessageBox.Show("Se elimino correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un cliente .", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
