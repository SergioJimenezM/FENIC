using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class NumeroConsecutivoType
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"\d{20,20}")]
        public String NumeroConsecutivo { get; set; }
    }
}
