using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    public class CodigosDeSeguridad
    {
        public int sucursal { get; set; }
        public int posicion { get; set; }
        public int tipoDeComprobante { get; set; }
        private int numeroDeComprobante { get; set; }

        [NotMapped]
        string formato = "";

        public string GenerarConsecutivo()
        {
            string numeroGenerado = numeroDeComprobante.ToString("D20");
            numeroDeComprobante++;

            return numeroGenerado;
        }

        public string GenerarClave()
        {
            return null;
        }

        public string GenerarCodigoDeSeguridad()
        {
            return null;
        }
    }
}
