using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WindowsFormsApp1.AppModel;

namespace WindowsFormsApp1.Clases
{
    internal class ClassMedicamentos
    {

        FarmaciaEntities db = new FarmaciaEntities();
        public bool Guardar(TblMedicamentos admin)
        {
            db.TblMedicamentos.Add(admin);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(TblMedicamentos admin)
        {
            db.TblMedicamentos.Remove(admin);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(TblMedicamentos admin)
        {
            db.Entry(admin).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public  TblMedicamentos Buscar(int Cod)
        {
            TblMedicamentos admin;
            admin = db.TblMedicamentos.DefaultIfEmpty(null).FirstOrDefault(c => c.FabMedId == Cod);
            return admin;
        }
        public List<TblMedicamentos> Listar()
        {
            return db.TblMedicamentos.ToList();
        }
        public void EliminarVencidos()
        {
            var medicamentosVencidos = db.TblMedicamentos.Where(m => m.FechaVencimiento< DateTime.Now).ToList();
            foreach (var medicamento in medicamentosVencidos)
            {
                db.TblMedicamentos.Remove(medicamento);
            }
            db.SaveChanges();
        }

    }
}

