using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
namespace LogicaDeNegocio
{
    class Factura
    {
        public void agregar(facturaElectronica nuevo)
        {
            OperacionesConFactura op = new OperacionesConFactura();
            op.agregar(nuevo);
        }

        public facturaElectronica buscar(int id)
        {
            OperacionesConFactura op = new OperacionesConFactura();
            return op.buscar(id);
        }

        public void editar(facturaElectronica PorEditar)
        {
            OperacionesConFactura op = new OperacionesConFactura();
            op.editar(PorEditar);
        }

        public void eliminar(facturaElectronica PorEliminar)
        {
            OperacionesConFactura op = new OperacionesConFactura();
            op.eliminar(PorEliminar);
        }
    }
}
