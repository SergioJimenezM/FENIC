using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class CodigoType
    {
        public int ID { get; set; }
        [Required]
        public String Tipo { get; set; }
        [Required]
        [StringLength(20)]
        public String Codigo { get; set; }

    }
}
