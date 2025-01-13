using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class EquipoDTO
    {
        [Display(Name = "ID")]
        public int equ_id { get; set; }
        [Display(Name = "Código")]
        public string equ_code { get; set; }
        [Display(Name = "Marca")]
        public int Marca_Id { get; set; }
        [Display(Name = "Marca")]
        public string Marca_Nombre { get; set; }
        [Display(Name = "Nombre")]
        public string equ_nom { get; set; }
        [Display(Name = "Descripción")]
        public string equ_desc { get; set; }
        [Display(Name = "Precio de Compra")]
        public decimal equ_prec_com { get; set; }
        [Display(Name = "Precio de Venta")]
        public decimal equ_prec_ven { get; set; }
        [Display(Name = "Stock")]
        public int equ_stock { get; set; }
        [Display(Name = "Fecha")]
        public string equ_fec { get; set; }
        [Display(Name = "Estado")]
        public char equ_est { get; set; }
    }
}
