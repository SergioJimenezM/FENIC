using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class TelefonoType
    {
        public int ID { get; set; }

        [MaxLength(3)]
        public int CodigoPais { get; set; }

        [MaxLength(20)]
        public int NumTelefono { get; set; }
    }
}
