using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickFood.Datos;

namespace QuickFood.Modelo
{
    public class Pedido
    {
        quickfoodDataContext db = new quickfoodDataContext();

        public List<pedido> toList()
        {
            List<pedido> list = db.pedido.ToList();
            return list;
        }

        public void create(pedido newpedido)
        {
            db.pedido.InsertOnSubmit(newpedido);
            db.SubmitChanges();
        }

        public void update(pedido newpedido)
        {
            pedido updatepedido = db.pedido.Single(r => r.pddId == newpedido.pddId);

            updatepedido.pddFecha = newpedido.pddFecha;
            updatepedido.pddEstado = newpedido.pddEstado;
            updatepedido.cltId = newpedido.cltId;
            updatepedido.msrId = newpedido.msrId;
            updatepedido.pddTotal = newpedido.pddTotal;

            db.SubmitChanges();
        }

        public void delete(int idpedido)
        {
            pedido deletepedido = db.pedido.Single(r => r.pddId == idpedido);
            db.pedido.DeleteOnSubmit(deletepedido);
            db.SubmitChanges();

        }

        public pedido obtener(int pddId)
        {
            pedido searchpedido = db.pedido.Single(r => r.pddId == pddId);
            return searchpedido;
        }

        public List<pedido> listarPorFecha(DateTime fecha)
        {
            List<pedido> listSearchPedido = db.pedido.Where(p=>p.pddFecha.Value.Date == fecha.Date).ToList();

            return listSearchPedido;

        }

        public List<pedido> listarPorCliente(String clienteNombre)
        {
            List<pedido> listSearchPedido = db.pedido.Where(p => p.cliente.cltNombre.Equals(clienteNombre)).ToList();

            return listSearchPedido;

        }

        public List<pedido> listarPorMesero(String meseroNombre)
        {
            List<pedido> listSearchPedido = db.pedido.Where(p => p.mesero.msrNombre.Equals(meseroNombre)).ToList();

            return listSearchPedido;

        }
    }
}
