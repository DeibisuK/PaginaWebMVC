using PaginaWebMVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginaWebMVC.ViewModels
{
    public class GetCargosVM
    {
        public List<CargosDTO> cargos { get; set; }
        public CargosDTO newCargo { get; set; }
    }
}