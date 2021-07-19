using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuickFood.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void abrirFormHija(object frm)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);
            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(fh);
            panelContenedor.Tag = fh;
            fh.Show();
        }
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormCliente());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormPedido());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FrmPedidoHistory());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FrmMeseroCRUD());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FrmPlatoCRUD());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormCocina());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormCaja());
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FrmEstadistica());
        }
    }
}
