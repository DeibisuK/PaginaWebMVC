using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class AlquilerDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Equipo")]
        public int Equipo_Id { get; set; }
        [Display(Name = "Equipo")]
        public string Equipo_Nombre { get; set; }
        [Display(Name = "Fecha Inicio")]
        public string Fecha_Ini { get; set; }
        [Display(Name = "Fecha Fin")]
        public string Fecha_Fin { get; set; }
        [Display(Name = "Fecha")]
        public string Fecha_Fin_Re { get; set; }
        [Display(Name = "Estado")]
        public char Estado { get; set; }


    }
}
