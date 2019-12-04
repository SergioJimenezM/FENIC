using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace AccesoADatos
{
    public class OperacionesConInventario
    {
        public void agregar(inventario nuevo)
        {
            var db = new Context();
            db.inventario.Add(nuevo);
            db.Entry(nuevo).State = EntityState.Added;
            db.SaveChanges();
        }

        public inventario buscar(int id) 
        {
            var db = new Context();
            return db.inventario.Find(id);
        }

        public void editar(inventario porEditar) 
        {
            var db = new Context();
            var DeLaDB = db.inventario.Find(porEditar.id);
            DeLaDB.producto = porEditar.producto;
            DeLaDB.unidadDeMedida = porEditar.unidadDeMedida;
            DeLaDB.existencias = porEditar.existencias;
            DeLaDB.descripcion = porEditar.descripcion;
            db.Entry(DeLaDB).State = EntityState.Modified;
            db.SaveChanges();
                
        }

        public void eliminar(inventario porBorrar)
        {
            var db = new Context();
            db.inventario.Remove(porBorrar);
            db.Entry(porBorrar).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<inventario> listar()
        {
            var db = new Context();
            return db.inventario.ToList<inventario>();
        }
    }
}
