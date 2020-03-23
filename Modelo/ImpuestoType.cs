using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class ImpuestoType
    {
        public int ID { get; set; }
        public String Codigo { get; set; }
        [DisplayName("Codigo de tarifa")]
        public int CodigoTarifa { get; set; }
        [Range(0, 9999.99)]
        public decimal Tarifa { get; set; }
        [DisplayName("Factor del IVA")]
        [Range(0, 99999.9999, ErrorMessage = "El valor no esta dentro del rango permitido")]
        public decimal FactorIVA { get; set; }
        public DecimalDineroType Monto { get; set; }
        public virtual ExoneracionType Exoneracion { get; set; }
    }
}
