using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
   public class UbicacionType
    {
        public int ID { get; set; }
        public int Provincia { get; set; }
        public int Canton { get; set; }
        public int Distrito { get; set; }
        public int Barrio { get; set; }
        [DisplayName("Otras señas")]
        [StringLength(250)]
        public int OtrasSenas { get; set; }
    }
}
