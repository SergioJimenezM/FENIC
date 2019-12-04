using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace AccesoADatos
{
    public class OperacionesConEmisor
    {
        public List<emisor> Listar()
        {
            var db = new Context();
            var resultado = db.emisor.ToList();
            return resultado;
        }
        public void agregar(emisor nuevo)
        {
            var db = new Context();
            db.emisor.Add(nuevo);
            db.Entry(nuevo).State = EntityState.Added;
            db.SaveChanges();
        }

        public emisor buscar(int id)
        {
            var db = new Context();
            return db.emisor.Find(id);
        }

        public void editar(emisor porEditar)
        {
            var db = new Context();
            var DeLaDB = db.emisor.Find(porEditar.id);
            DeLaDB.Nombre = porEditar.Nombre;
            DeLaDB.Identificacion = porEditar.Identificacion;
            DeLaDB.NombreComercial = porEditar.NombreComercial;
            DeLaDB.Ubicacion = porEditar.Ubicacion;
            DeLaDB.Telefono = porEditar.Telefono;
            DeLaDB.CorreoElectronico = porEditar.CorreoElectronico;
            DeLaDB.identificacion1 = porEditar.identificacion1;
            DeLaDB.facturaElectronica = porEditar.facturaElectronica;
            db.Entry(DeLaDB).State = EntityState.Modified;
            db.SaveChanges();

        }

        public void eliminar(emisor porBorrar)
        {
            var db = new Context();
            db.emisor.Remove(porBorrar);
            db.Entry(porBorrar).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
