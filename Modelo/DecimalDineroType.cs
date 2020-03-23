using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class DecimalDineroType
    {
        public int ID { get; set; }
        
        [Range(0, 9999999999999.99999)]
        public decimal Monto { get; set; }
    }
}
