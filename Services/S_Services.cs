using Entities;
using ServicesContex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class S_Services
    {
        public static List<ServicesEntity> ListaServicios()
        {
            using (var db = new Context())
            {
                return db.Services.ToList();
            }
        }

        public static void CrearPersona(ServicesEntity _oServices)
        {
            using (var db = new Context())
            {
                db.Services.Add(_oServices);
                db.SaveChanges();
            }
        }
    }
}
