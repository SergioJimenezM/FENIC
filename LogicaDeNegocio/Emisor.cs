using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
namespace LogicaDeNegocio
{
    class Emisor
    {
        public List<emisor> Listar()
        {
            OperacionesConEmisor OperacionesConEmisor = new OperacionesConEmisor();
            return OperacionesConEmisor.Listar();
        }
        public void agregar(emisor nuevo)
        {
            OperacionesConEmisor op = new OperacionesConEmisor();
            op.agregar(nuevo);
        }

        public emisor buscar(int id)
        {
            OperacionesConEmisor op = new OperacionesConEmisor();
            return op.buscar(id);
        }

        public void editar(emisor PorEditar)
        {
            OperacionesConEmisor op = new OperacionesConEmisor();
            op.editar(PorEditar);
        }

        public void eliminar(emisor PorEliminar)
        {
            OperacionesConEmisor op = new OperacionesConEmisor();
            op.eliminar(PorEliminar);
        }
    }
}
