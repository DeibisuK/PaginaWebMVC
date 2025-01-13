using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class ServiciosDTO
    {
        [Display(Name = "ID")]
        public int serv_id { get; set; }
        [Display(Name = "Nombre")]
        public string serv_nom { get; set; }
        [Display(Name = "Descripción")]
        public string serv_desc { get; set; }
        [Display(Name = "Costo")]
        public decimal serv_costo { get; set; }
        [Display(Name = "Fecha")]
        public string serv_fec { get; set; }
        [Display(Name = "Estado")]
        public char serv_est { get; set; }
        
    }
}
