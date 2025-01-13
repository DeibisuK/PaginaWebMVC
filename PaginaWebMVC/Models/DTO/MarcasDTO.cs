using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class MarcasDTO
    {
        [Display(Name = "ID")]
        public int mar_id { get; set; }
        [Display(Name = "Descripcion")]
        public string mar_desc { get; set; }
        [Display(Name = "Fecha")]
        public string mar_fec { get; set; }
        [Display(Name = "Estado")]
        public char mar_est { get; set; }
        
    }
}
