using Entities;
using ServicesContex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class S_Persons
    {
        public static List<PersonsEntity> ListaPerosnas()
        {
            using (var db = new Context())
            {
                return db.Persons.ToList();
            }
        }

        public static void CrearPersona(PersonsEntity _oPersons)
        {
            using (var db = new Context())
            {
                db.Persons.Add(_oPersons);
                db.SaveChanges();
            }
        }


    }
}
