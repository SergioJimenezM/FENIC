using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class OtrosCargosType
    {
        public int ID { get; set; }
        public String TipoDocumento { get; set; }
        [StringLength(12)]
        [DisplayName("Numero de cedula fisica o juridica")]
        public String NumeroIdentidadTercero { get; set; }
        [DisplayName("Nombre fisico o juridico")]
        [StringLength(100)]
        public String NombreTercero { get; set; }
        [StringLength(160)]
        public String Detalle { get; set; }
        [Range(0,999999.99999)]
        public decimal Porcentaje { get; set; }
        public DecimalDineroType MontoCargo { get; set; }
    }
}
