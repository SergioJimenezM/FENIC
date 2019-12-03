using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
namespace LogicaDeNegocio
{
    public class Inventario
    {
        public void agregar(inventario nuevo) 
        {
            OperacionesConInventario op = new OperacionesConInventario();
            op.agregar(nuevo);
        }

        public inventario buscar(int id) 
        {
            OperacionesConInventario op = new OperacionesConInventario();
            return op.buscar(id);
        }

        public void editar(inventario PorEditar) 
        {
            OperacionesConInventario op = new OperacionesConInventario();
            op.editar(PorEditar);
        }

        public void eliminar(inventario PorEliminar) 
        {
            OperacionesConInventario op = new OperacionesConInventario();
            op.eliminar(PorEliminar);
        }
    }
}
