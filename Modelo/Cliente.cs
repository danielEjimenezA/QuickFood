using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickFood.Datos;

namespace QuickFood.Modelo
{
    public class Cliente
    {
        quickfoodDataContext db = new quickfoodDataContext();

        public List<cliente> toList()
        {
            List<cliente> list = db.cliente.ToList();
            return list;
        }
    }
}
