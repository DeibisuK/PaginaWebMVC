using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaginaWebMVC.Models.DTO
{
    public class EmpleadosDTO
    {
        [Display(Name ="ID")]
        public int emp_id { get; set; }
        [Display(Name = "Cedula")]
        public string emp_ced { get; set; }
        [Display(Name = "Nombres")]
        public string emp_nom { get; set; }
        [Display(Name = "Apellidos")]
        public string emp_ape { get; set; }
        [Display(Name = "Cargo")]
        public int cargo_id { get; set; }
        [Display(Name = "Cargo")]
        public string cargo_nom { get; set; }
        [Display(Name = "Salario")]
        public double emp_salario { get; set; }
        [Display(Name = "Ciudad")]
        public int ciu_id { get; set; }
        [Display(Name = "Ciudad")]
        public string ciu_nom { get; set; }
        [Display(Name = "Fecha Contrato")]
        public DateTime emp_fec_contrat { get; set; }
        [Display(Name = "Telefono")]
        public string emp_tel { get; set; }
        [Display(Name = "Estado")]
        public string emp_est { get; set; }

    }
}