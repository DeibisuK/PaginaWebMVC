//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaginaWebMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ciudad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ciudad()
        {
            this.clientes = new HashSet<clientes>();
            this.empleados = new HashSet<empleados>();
        }
    
        public int ciu_id { get; set; }
        public string ciu_nom { get; set; }
        public Nullable<int> prov_id { get; set; }
        public string ciu_est { get; set; }
        public Nullable<System.DateTime> ciu_fec { get; set; }
    
        public virtual provincia provincia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<clientes> clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empleados> empleados { get; set; }
    }
}
