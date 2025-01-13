using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class CategoriaDTO
    {
        [Display(Name = "ID")]
        public int cat_id { get; set; }
        [Display(Name = "Descuento")]
        public string cat_desc { get; set; }
        [Display(Name = "Fecha")]
        public string cat_fec { get; set; }
        [Display(Name = "Estado")]
        public char cat_est { get; set; }
        
    }
}
