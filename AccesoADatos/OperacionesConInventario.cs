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
        public void nuevo(inventario nuevo)
        {
            var db = new FacturaDigitalEntities1();
            db.inventario.Add(nuevo);
            db.Entry(nuevo).State = EntityState.Added;
            db.SaveChanges();
        }
    }
}
