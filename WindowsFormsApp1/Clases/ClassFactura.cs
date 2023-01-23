using System.Collections.Generic;
using System.Data;
using System.Linq;
using WindowsFormsApp1.AppModel;

namespace WindowsFormsApp1.Clases
{
    internal class ClassFactura
    {

        FarmaciaEntities db = new FarmaciaEntities();
        public bool Guardar(TblFactura admin)
        {
            db.TblFactura.Add(admin);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(TblFactura admin)
        {
            db.TblFactura.Remove(admin);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(TblFactura admin)
        {
            db.Entry(admin).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public TblFactura Buscar(int Cod)
        {
            TblFactura admin;
            admin = db.TblFactura.DefaultIfEmpty(null).FirstOrDefault(c => c.FacId == Cod);
            return admin;
        }
        public List<TblFactura> Listar()
        {

            return db.TblFactura.ToList();
        }


    }
}

