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
        public FormCliente()
        {

            InitializeComponent();
        }

        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cliente cli = new cliente();
                cli.cltNombre = textBox1.Text;
                cli.cltIdentificacion = textBox2.Text;
                cli.cltDireccion = textBox3.Text;
                cli.cltTelefono = textBox4.Text;
                db.cliente.InsertOnSubmit(cli);
                db.SubmitChanges();
                limpiar();
                MessageBox.Show("Se guardo correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
    }
}
