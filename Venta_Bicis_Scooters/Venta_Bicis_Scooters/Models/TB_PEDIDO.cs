//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Venta_Bicis_Scooters.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_PEDIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_PEDIDO()
        {
            this.TB_DETALLE_PEDIDOS = new HashSet<TB_DETALLE_PEDIDOS>();
        }
    
        public int nro_pedido { get; set; }
        public System.DateTime fecha_pedido { get; set; }
        public decimal sub_total { get; set; }
        public decimal igv_pedido { get; set; }
        public decimal total_pedido { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_DETALLE_PEDIDOS> TB_DETALLE_PEDIDOS { get; set; }
    }
}
