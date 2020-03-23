using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class CodigoMonedaType
    {
        public int ID { get; set; }
        [Required]
        [DisplayName("Codigo de la moneda")]
        public String CodigoMoneda { get; set; }
        [DisplayName("Tipo de cambio")]
        public DecimalDineroType TipoCambio { get; set; }

    }
}
