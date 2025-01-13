using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginaWebMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }
    }
}