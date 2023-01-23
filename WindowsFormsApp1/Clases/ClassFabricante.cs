using System.Collections.Generic;
using System.Data;
using System.Linq;
using WindowsFormsApp1.AppModel;

namespace WindowsFormsApp1.Clases
{
    public class ClassFabricante
    {

        FarmaciaEntities db = new FarmaciaEntities();
        public bool Guardar(TblFabricante admin)
        {
            db.TblFabricante.Add(admin);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(TblFabricante admin)
        {
            db.TblFabricante.Remove(admin);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(TblFabricante admin)
        {
            db.Entry(admin).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public TblFabricante Buscar(int Cod)
        {
            TblFabricante admin;
            admin = db.TblFabricante.DefaultIfEmpty(null).FirstOrDefault(c => c.FabId == Cod);
            return admin;
        }
        public List<TblFabricante> Listar()
        {
            return db.TblFabricante.ToList();
        }


    }
}

