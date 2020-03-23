using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public enum TipoEnum { Física = 01, Juridica = 02, DIMEX = 03, NITE = 04 }
    public class IdentificacionType
    {
        public int ID { get; set; }

        public TipoEnum Tipo { get; set; }

        [StringLength(12)]
        [DisplayName("Numero de identificacion")]
        public String Numero { get; set; }

    }
}
