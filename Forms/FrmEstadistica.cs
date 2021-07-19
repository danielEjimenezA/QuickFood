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
    public partial class FrmEstadistica : Form
    {

        private Pedido clsPedido = new  Pedido();
        public List<pedido> listPedidos = new List<pedido>();
        int i = 0;

        Pen p = new Pen(Color.Black);
        Pen p1 = new Pen(Color.OrangeRed);
        Pen p2 = new Pen(Color.DarkGreen);

        Font t1 = new Font("Arial", 12);
        Font t2 = new Font("Arial", 12);

        bool band = true;

        public FrmEstadistica()
        {
            InitializeComponent();
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {
            listarPedidos();
        }

        private void pnlGráfica1_Paint(object sender, PaintEventArgs e)
        {
            if (band)
            {
                graficarBarras(pnlGráfica1.CreateGraphics(), listPedidos, 100, 300);
            }
        }

        private void pnlGráfica2_Paint(object sender, PaintEventArgs e)
        {
            if (band)
            {
                graficarPastel(pnlGráfica2.CreateGraphics(), listPedidos, 50, 125);
            }
        }

        public void listarPedidos()
        {
            listPedidos = clsPedido.toList();
        }

        public void graficarBarras(Graphics t, List<pedido> A, int x, int y)
        {
            int contS = 0, contC = 0, a = 20, ancho = 40;

            for (i = 0; i < A.Count; i++)
            {
                contS++;

                //Ejes
                t.DrawLine(p1, x, y, x + 300, y);
                t.DrawLine(p1, x, y, x, y - 250);
                t.DrawString("Tipo", t2, Brushes.White, x + 300, y);
                t.DrawString("# Pedidos", t2, Brushes.White, x, y - 250);

                //Leyenda
                t.FillRectangle(Brushes.LightBlue, x + 270, y - 150, ancho, ancho / 2);

                t.DrawString("Pedidos", t1, Brushes.Black, x + 320, y - 150);

                //Asegurado
                t.FillRectangle(Brushes.LightBlue, x + 50, y - (contS * a), ancho, contS * a);
                t.DrawRectangle(p2, x + 50, y - (contS * a), ancho, contS * a);
                t.DrawLine(p1, x, y - (contS * a), x + 50 + ancho, y - (contS * a));
                t.DrawString("Pedidos", t1, Brushes.Black, x + 50, y + 30);
                t.DrawString("" + contS, t1, Brushes.Black, x - 20, y - (contS * a));

            }
        }

        public void graficarPastel(Graphics t, List<pedido> A, int x, int y)
        {
            int ptot = 0, s = 0, ns = 0;
            s++;
            ptot = A.Count;

            if (ptot != 0)
            {

                t.DrawString("Pedidos " + (double)(s * 100 / ptot), t2, Brushes.Black, x + 230, y + 60);

                t.DrawRectangle(p1, x + 210, y + 60, 10, 10);

                t.FillEllipse(Brushes.Blue, x - 3, y - 3, 154, 154);

                t.FillPie(Brushes.LightBlue, x, y, 150, 150, 0, (int)(s * 360 / ptot));
                t.FillRectangle(Brushes.LightBlue, x + 210, y + 60, 10, 10);

            }
        }
    }
}
