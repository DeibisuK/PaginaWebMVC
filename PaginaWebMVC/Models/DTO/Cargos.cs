using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaginaWebMVC.Models.DTO
{
    public class Cargos
    {
        [Display(Name = "ID")]
        public int cargo_id { get; set; }
        [Display(Name = "Nombre")]
        public string cargo_nom { get; set; }
    }
}