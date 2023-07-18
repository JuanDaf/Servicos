using Entities;
using ServicesContex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class S_Detalles
    {
        public static List<DetallesEntity> ListaDetalles()
        {
            using (var db = new Context())
            {
                return db.Detalles.ToList();
            }
        }

        public static void CrearPersona(DetallesEntity _oDetalles)
        {
            using (var db = new Context())
            {
                db.Detalles.Add(_oDetalles);
                db.SaveChanges();
            }
        }
    }
}
