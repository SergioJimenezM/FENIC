using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class ClaveType
    {
        public int ID { get; set; }
        [StringLength(50)]
        [RegularExpression(@"\d{50,50}")]
        public String Clave { get; set; }
    }
}
