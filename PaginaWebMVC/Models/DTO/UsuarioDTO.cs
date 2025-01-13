using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaWebMVC.Models.DTO
{
    public class UsuarioDTO
    {
        public int usu_id { get; set; }
        public string usu_nom { get; set; }
        public string usu_email { get; set; }
        public string usu_contra { get; set; }
        public string usu_repeat { get; set; }
        public string usu_est { get; set; }
        public string usu_fec_reg { get; set; }
    }
}
