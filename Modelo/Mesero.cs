using QuickFood.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFood.Modelo
{
    public class Mesero
    {
        quickfoodDataContext db = new quickfoodDataContext();

        public List<mesero> toList()
        {
            List<mesero> list = db.mesero.ToList();
            return list;
        }

        public void create(mesero newMesero)
        {
            db.mesero.InsertOnSubmit(newMesero);
            db.SubmitChanges();
        }

        public void update(mesero newMesero)
        {
            mesero updateMesero = db.mesero.Single(r => r.msrId == newMesero.msrId);

            updateMesero.msrIdentificacion = newMesero.msrIdentificacion;
            updateMesero.msrNombre = newMesero.msrNombre;

            db.SubmitChanges();
        }

        public void delete(int idMesero)
        {
            mesero deleteMesero = db.mesero.Single(r => r.msrId == idMesero);
            db.mesero.DeleteOnSubmit(deleteMesero);
            db.SubmitChanges();

        }

        public mesero obtener(int msrId)
        {
            mesero searchMesero = db.mesero.Single(r => r.msrId == msrId);
            return searchMesero;
        }
    }
}
