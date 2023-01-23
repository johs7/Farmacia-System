using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using WindowsFormsApp1.AppModel;

namespace WindowsFormsApp1.Clases
{
    public class ClassVendedor
    {

        FarmaciaEntities db= new FarmaciaEntities();
        public bool Guardar(TblVendedor ven)
        {
            db.TblVendedor.Add(ven);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Eliminar(TblVendedor ven)
        {
            db.TblVendedor.Remove(ven);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(TblVendedor ven)
        {
            db.Entry(ven).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);
        }

        public TblVendedor Buscar(int Cod)
        {
            TblVendedor ven;
            ven = db.TblVendedor.DefaultIfEmpty(null).FirstOrDefault(c => c.IdVen == Cod);
            return ven;
        }
        public List<TblVendedor> Listar()
        {
            return db.TblVendedor.ToList();
        }

        public bool Verificar(string name, string pass)
        {
            TblVendedor adm;
            adm = db.TblVendedor.DefaultIfEmpty(null).FirstOrDefault
                (ad => ad.NomVen == name && ad.ContraVen == pass);
            if (adm.NomVen == name && adm.ContraVen == pass)
                return true;
            else
                return false;

        }
    }
}

