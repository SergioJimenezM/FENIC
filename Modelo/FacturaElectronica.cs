using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class FacturaElectronica
    {
        public virtual ClaveType Clave { get; set; }
        [DisplayName("Codigo de actividad")]
        [StringLength(6)]
        public String CodigoActividad { get; set; }
        [DisplayName("Numero consecutivo")]
        public virtual NumeroConsecutivoType NumeroConsecutivo { get; set; }
        [DisplayName("Fecha de emision")]
        public DateTime FechaEmision { get; set; }
        public virtual EmisorType Emisor { get; set; }
        public virtual ReceptorType Receptor { get; set; }
        [DisplayName("Condicion de la venta")]
        public String CondicionVenta { get; set; }
        [DisplayName("Plazo del credito")]
        [StringLength(10)]
        public String PlazoCrecito { get; set; }
        [DisplayName("Medio de pago")]
        public String MedioPago { get; set; }

    }
}
