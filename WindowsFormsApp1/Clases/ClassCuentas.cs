using System.Collections.Generic;
using System.Data;
using System.Linq;
using WindowsFormsApp1.AppModel;

namespace WindowsFormsApp1.Clases
{
    internal class ClassCuentas
    {

        FarmaciaEntities db = new FarmaciaEntities();
        public bool Guardar(TblCuentas admin)
        {
            db.TblCuentas.Add(admin);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(TblCuentas admin)
        {
            db.TblCuentas.Remove(admin);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(TblCuentas admin)
        {
            db.Entry(admin).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public TblCuentas Buscar(int Cod)
        {
            TblCuentas admin;
            admin = db.TblCuentas.DefaultIfEmpty(null).FirstOrDefault(c => c.IdCuenta == Cod);
            return admin;
        }
        public List<TblCuentas> Listar()
        {
            return db.TblCuentas.ToList();
        }


    }
}

