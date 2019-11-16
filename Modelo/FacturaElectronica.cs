using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class FacturaElectronica
    {
        public string clave { get; set; }
        
        [Display(Name = "Codigo de Actividad")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Los codigos de actividad deben tener 6 digitos")]
        public string CodigoActividad { get; set; };
        public string NumeroConsecutivo { get; set; }



    }
}
