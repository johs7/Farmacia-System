using System.Collections.Generic;
using System.Data;
using System.Linq;
using WindowsFormsApp1.AppModel;

namespace WindowsFormsApp1.Clases
{
    public class ClassCliente
    {

        FarmaciaEntities db = new FarmaciaEntities();
        public bool Guardar(TblCliente admin)
        {
            db.TblCliente.Add(admin);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(TblCliente admin)
        {
            db.TblCliente.Remove(admin);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(TblCliente admin)
        {
            db.Entry(admin).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public TblCliente Buscar(int Cod)
        {
            TblCliente admin;
            admin = db.TblCliente.DefaultIfEmpty(null).FirstOrDefault(c => c.IdCliente == Cod);
            return admin;
        }
        public List<TblCliente> Listar()
        {
            return db.TblCliente.ToList();
        }

       
    }
}

