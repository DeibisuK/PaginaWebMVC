using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class PagosDTO
    {
        [Display(Name = "ID")]
        public int pag_id { get; set; }
        [Display(Name = "Descripcion")]
        public string pag_desc { get; set; }
        [Display(Name = "Fecha")]
        public string pag_fec { get; set; }
        [Display(Name = "Estado")]
        public char pag_est { get; set; }
        
    }
}
