using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickFood.Reportes;
using QuickFood.Datos;

namespace QuickFood.Forms
{
    public partial class FormCaja : Form
    {

        quickfoodDataContext fb = new quickfoodDataContext();
        pedido pedidoEncontrado = new pedido();
        int pedidoId = 0;
        public FormCaja()
        {
            
            InitializeComponent();

            mostrarPedidos();
        }

        public void mostrarPedidos()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.CurrentCell = null;
            dataGridView1.AutoGenerateColumns = false;
            int i = 0;
            foreach (pedido ped in fb.pedido.Where(x => x.pddEstado.Equals("DESPACHADO")))
            {
                dataGridView1.Rows.Insert(i, ped.pddId, ped.pddFecha, ped.pddTotal, ped.cliente.cltNombre);
                i++;
            }
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    pedidoId = int.Parse(row.Cells[0].Value.ToString());
                    obtener(pedidoId);

                    if(pedidoEncontrado != null)
                    {
                        ReportParameter inicio = new ReportParameter("clienteId", pedidoEncontrado.cliente.cltId.ToString());
                        ReportParameter pedido = new ReportParameter("pedidoId", pedidoId.ToString());

                        reportViewer1.LocalReport.SetParameters(inicio);
                        reportViewer1.LocalReport.SetParameters(pedido);



                        ReportDataSource dsSalesOrder = new ReportDataSource();
                        dsSalesOrder.Name = "Cliente";
                        dsSalesOrder.Value = fb.cliente.ToArray();

                        ReportDataSource dtDetalle = new ReportDataSource();
                        dtDetalle.Name = "Detalle";
                        dtDetalle.Value = fb.pedidodetalle.ToArray();

                        reportViewer1.LocalReport.DataSources.Add(dsSalesOrder);
                        reportViewer1.LocalReport.DataSources.Add(dtDetalle);

                        this.reportViewer1.RefreshReport();
                    }
                }
            }
        }

        private void obtener(int id)
        {
            pedidoEncontrado = null;
            if(id != 0)
            {
               pedidoEncontrado =  fb.pedido.First(x=>x.pddId == id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pedidoEncontrado != null)
            {
                pedidoEncontrado.pddEstado = "FACTURADO";
                fb.SubmitChanges();
                mostrarPedidos();
                reportViewer1.Clear();
                MessageBox.Show("Se facturo correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Elija un ppedido.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
