using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class ClienteDTO
    {
        [Display(Name = "ID")]
        public int cli_id { get; set; }
        [Display(Name = "Cédula")]
        public string cli_ced { get; set; }
        [Display(Name = "Nombre")]
        public string cli_nom { get; set; }
        [Display(Name = "Apellido")]
        public string cli_ape { get; set; }
        [Display(Name = "Teléfono")]
        public string cli_tel { get; set; }
        [Display(Name = "Ciudad")]
        public int Ciudad_Id { get; set; }
        [Display(Name = "Ciudad")]
        public string Ciudad_Nombre { get; set; }
        [Display(Name = "Dirección")]
        public string cli_dir { get; set; }
        [Display(Name = "Email")]
        public string cli_email { get; set; }
        [Display(Name = "Fecha")]
        public string cli_fecha { get; set; }
        [Display(Name = "Estado")]
        public char cli_est { get; set; }
        
    }
}
