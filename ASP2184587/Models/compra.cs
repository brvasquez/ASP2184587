//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP2184587.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public compra()
        {
            this.producto_compra = new HashSet<producto_compra>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> total { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public Nullable<int> id_cliente { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual usuario usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<producto_compra> producto_compra { get; set; }
    }
}
