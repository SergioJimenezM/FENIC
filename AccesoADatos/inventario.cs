//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoADatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class inventario
    {
        public int id { get; set; }
        public string producto { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> existencias { get; set; }
        public Nullable<int> unidadDeMedida { get; set; }
        public Nullable<int> precio { get; set; }
    
        public virtual tipoDecimalDinero tipoDecimalDinero { get; set; }
        public virtual unidadDeMedida unidadDeMedida1 { get; set; }
    }
}
