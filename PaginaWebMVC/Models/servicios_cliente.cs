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
    
    public partial class servicios_cliente
    {
        public int cli_id { get; set; }
        public int serv_id { get; set; }
        public Nullable<System.DateTime> sc_fec_asig { get; set; }
        public string sc_est { get; set; }
    
        public virtual clientes clientes { get; set; }
        public virtual servicios servicios { get; set; }
    }
}
