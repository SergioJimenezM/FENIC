using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class DetalleDelServicio
    {
        public int ID { get; set; }
        public int LineaDetalle { get; set; }
        public int NumeroDeLinea { get; set; }
        public String Codigo { get; set; }
        public CodigoType CodigoComercial { get; set; }
        public decimal Cantidad { get; set; }
        public UnidadMedidaType UnidadMedida { get; set; }
        public String UnidadMedidaComercial { get; set; }
        public String Detalle { get; set; }
        public DecimalDineroType PrecioUnitario { get; set; }
        public DecimalDineroType MontoTotal { get; set; }
        public DescuentoType Descuento { get; set; }
        public DecimalDineroType SubTotal { get; set; }
        public DecimalDineroType BaseImponible { get; set; }
        public ImpuestoType Impuesto { get; set; }
        public DecimalDineroType ImpuestoNeto { get; set; }
        public DecimalDineroType MontoTotalLinea { get; set; }

    }
}
