using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
   public class EmisorType
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }


        public virtual IdentificacionType Identificacion { get; set; }
        [DisplayName("Nombre comercial")]
        public String NombreComercial { get; set; }

        public virtual UbicacionType Ubicacion { get; set; }

        public virtual TelefonoType Telefono { get; set; }

        public virtual TelefonoType Fax { get; set; }

        [Required]
        [StringLength(160)]
        [DisplayName("Correo electrónico")]
        [RegularExpression(@"\s*\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*", ErrorMessage = "El formato del correo es incorrecto")]
        String CorreoElectronico { get; set; }
    }
}
