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
    
    public partial class materiales
    {
        public int mat_id { get; set; }
        public string mat_code { get; set; }
        public Nullable<int> mar_id { get; set; }
        public Nullable<int> cat_id { get; set; }
        public string mat_nom { get; set; }
        public string mat_desc { get; set; }
        public int mat_stock { get; set; }
        public Nullable<decimal> mat_prec_com { get; set; }
        public Nullable<decimal> mat_prec_ven { get; set; }
        public Nullable<System.DateTime> mat_fec { get; set; }
        public string mat_est { get; set; }
    
        public virtual categoria categoria { get; set; }
        public virtual marcas marcas { get; set; }
    }
}
