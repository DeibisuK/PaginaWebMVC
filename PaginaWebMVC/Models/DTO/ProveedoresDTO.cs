using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class ProveedoresDTO
    {
        [Display(Name = "ID")]
        public int prove_id { get; set; }
        [Display(Name = "RUC")]
        public string prove_ruc { get; set; }
        [Display(Name = "Representante")]
        public string prove_represen { get; set; }
        [Display(Name = "Nombre")]
        public string prove_nom { get; set; }
        [Display(Name = "Dirección")]
        public string prove_dir { get; set; }
        [Display(Name = "Teléfono")]
        public string prove_tel { get; set; }
        [Display(Name = "Email")]
        public string prove_email { get; set; }
        [Display(Name = "Fecha")]
        public string prove_fec { get; set; }
        [Display(Name = "Estado")]
        public char prove_est { get; set; }
        
    }
}
