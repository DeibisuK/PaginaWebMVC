using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class ProvinciaDTO
    {
        [Display(Name = "ID")]
        public int prov_id { get; set; }
        [Display(Name = "Nombre")]
        public string prov_nom { get; set; }
        [Display(Name = "Fecha")]
        public string prov_fecha { get; set; }
        [Display(Name = "Estado")]
        public char prov_est { get; set; }
        
    }
}
