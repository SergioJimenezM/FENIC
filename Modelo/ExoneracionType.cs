using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class ExoneracionType
    {
        public int ID { get; set; }
        [Required]
        public virtual TipoDocumentoCatalogo TipoDocumento { get; set; }
        [StringLength(40)]
        [Required]
        public String NumeroDocumento { get; set; }
        [Required]
        [StringLength(160)]
        public String NombreInstitucion { get; set; }

        [Required]
        public DateTime FechaEmision { get; set; }
        [Required]
        public int PorcentajeExoneracion { get; set; }
        [Required]
        public DecimalDineroType MontoExoneracion { get; set; }


    }
}
