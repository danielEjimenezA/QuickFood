using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickFood.Datos;

namespace QuickFood.Modelo
{
    public class Plato
    {
        quickfoodDataContext db = new quickfoodDataContext();

        public List<plato> toList()
        {
            List<plato> list = db.plato.ToList();
            return list;
        }

        public void create(plato newPlato)
        {
            db.plato.InsertOnSubmit(newPlato);
            db.SubmitChanges();
        }

        public void update(plato newPlato)
        {
            plato updatePlato = db.plato.Single(r => r.pltId == newPlato.pltId);

            updatePlato.pltDescripcion = newPlato.pltDescripcion;

            db.SubmitChanges();
        }

        public void delete(int idPlato)
        {
            plato deletePlato = db.plato.Single(r => r.pltId == idPlato);
            db.plato.DeleteOnSubmit(deletePlato);
            db.SubmitChanges();
        }

        public plato obtener(int pltId)
        {
            plato searchPlato = db.plato.Single(r => r.pltId == pltId);
            return searchPlato;
        }
    }
}
