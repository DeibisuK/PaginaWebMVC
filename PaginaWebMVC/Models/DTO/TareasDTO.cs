using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class TareasDTO
    {
        [Display(Name = "ID")]
        public int tar_id { get; set; }
        [Display(Name = "Nombre")]
        public string tar_nom { get; set; }
        [Display(Name = "Descripción")]
        public string tar_desc { get; set; }
        [Display(Name = "Estado")]
        public char tar_est { get; set; }
    }
}
