using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class CompraDTO
    {
        [Display(Name = "ID")]
        public int comp_id { get; set; }
        [Display(Name = "Proveedor")]
        public int Proveedor_Id { get; set; }
        [Display(Name = "Usuario")]
        public int Usuario_Id { get; set; }
        [Display(Name = "Pago")]
        public int Pago_Id { get; set; }
        [Display(Name = "Proveedor")]
        public string Proveedor_Nombre { get; set; }
        [Display(Name = "Usuario")]
        public string Usuario_Nombre { get; set; }
        [Display(Name = "Pago")]
        public string Pago_Nombre { get; set; }
        [Display(Name = "Tipo de Documento")]
        public string comp_tip_doc { get; set; }
        [Display(Name = "Número de Documento")]
        public string comp_num_doc { get; set; }
        [Display(Name = "Total")]
        public decimal comp_total { get; set; }
        [Display(Name = "Estado")]
        public char comp_est { get; set; }
    }
}
