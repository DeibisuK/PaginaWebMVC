using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class ProyectosDTO
    {
        [Display(Name = "ID")]
        public int proy_id { get; set; }
        [Display(Name = "Nombre")]
        public string proy_nom { get; set; }
        [Display(Name = "Descripción")]
        public string proy_desc { get; set; }
        [Display(Name = "Fecha de Inicio")]
        public string proy_fecha_inicio { get; set; }
        [Display(Name = "Fecha de Fin")]
        public string proy_fecha_fin_real { get; set; }
        [Display(Name = "Presupuesto")]
        public decimal proy_presupuesto { get; set; }
        [Display(Name = "Fecha")]
        public string proy_fecha_fin_est { get; set; }
        [Display(Name = "Estado")]
        public char proy_est { get; set; }
    }
}
