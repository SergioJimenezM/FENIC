using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace AccesoADatos
{
    public class OperacionesConFactura
    {
        public void agregar(facturaElectronica nuevo)
        {
            var db = new Context();
            db.facturaElectronica.Add(nuevo);
            db.Entry(nuevo).State = EntityState.Added;
            db.SaveChanges();
        }

        public facturaElectronica buscar(int id)
        {
            var db = new Context();
            return db.facturaElectronica.Find(id);
        }

        public void editar(facturaElectronica porEditar)
        {
            var db = new Context();
            var DeLaDB = db.facturaElectronica.Find(porEditar.NumeroConsecutivo);
            DeLaDB.FechaEmision = porEditar.FechaEmision;
            DeLaDB.Emisor = porEditar.Emisor;
            DeLaDB.Receptor = porEditar.Receptor;
            DeLaDB.CondicionVenta = porEditar.CondicionVenta;
            DeLaDB.PlazoCredito = porEditar.PlazoCredito;
            DeLaDB.MedioPago = porEditar.MedioPago;
            DeLaDB.DetalleServicio = porEditar.DetalleServicio;
            DeLaDB.OtrosCargos = porEditar.OtrosCargos;
            DeLaDB.ResumenFactura = porEditar.ResumenFactura;
            DeLaDB.InformacionReferencia = porEditar.InformacionReferencia;
            DeLaDB.Otros = porEditar.Otros;
            DeLaDB.emisor1 = porEditar.emisor1;
            DeLaDB.receptor1 = porEditar.receptor1;
            DeLaDB.tipoDetalleServicio = porEditar.tipoDetalleServicio;
            DeLaDB.tipoMedioPago = porEditar.tipoMedioPago;
            db.Entry(DeLaDB).State = EntityState.Modified;
            db.SaveChanges();

        }

        public void eliminar(facturaElectronica porBorrar)
        {
            var db = new Context();
            db.facturaElectronica.Remove(porBorrar);
            db.Entry(porBorrar).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
