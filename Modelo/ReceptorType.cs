using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class ReceptorType
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }


        public virtual IdentificacionType Identificacion { get; set; }

        [DisplayName("Identificacion de extranjero")]
        [StringLength(20)]
        public string IdentificacionExtranjero { get; set; }

        [DisplayName("Nombre comercial")]
        [StringLength(80)]
        public String NombreComercial { get; set; }

        public virtual UbicacionType Ubicacion { get; set; }

        [DisplayName("Otras señas de la direccion para extranjeros")]
        [StringLength(300)]
        public String OtrasSenasExtranjero { get; set; }

        public TelefonoType Telefono { get; set; }

        public TelefonoType Fax { get; set; }

        [Required]
        [StringLength(160)]
        [DisplayName("Correo electrónico")]
        [RegularExpression(@"\s*\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*", ErrorMessage = "El formato del correo es incorrecto")]
        String CorreoElectronico { get; set; }
    }
}
