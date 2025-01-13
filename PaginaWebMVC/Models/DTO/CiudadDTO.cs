using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class CiudadDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Provincia")]
        public int Provincia_ID { get; set; }
        [Display(Name = "Provincia")]
        public string Provincia_Nombre { get; set; }
        [Display(Name = "Estado")]
        public char Estado { get; set; }
        [Display(Name = "Fecha")]
        public string Fecha { get; set; }
    }
}
