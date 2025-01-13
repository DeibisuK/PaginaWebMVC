using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class MaterialesDTO
    {
        [Display(Name = "ID")]
        public int mat_id { get; set; }
        [Display(Name = "Codigo")]
        public string mat_code { get; set; }
        [Display(Name = "Marca")]
        public int Marca_Id { get; set; }
        [Display(Name = "Marca")]
        public string Marca_Nombre { get; set; }
        [Display(Name = "Categoria")]
        public int Categoria_Id { get; set; }
        [Display(Name = "Categoria")]
        public string Categoria_Nombre { get; set; }
        [Display(Name = "Nombre")]
        public string mat_nom { get; set; }
        [Display(Name = "Descripcion")]
        public string mat_desc { get; set; }
        [Display(Name = "Stock")]
        public int mat_stock { get; set; }
        [Display(Name = "Precio de Compra")]
        public decimal mat_prec_com { get; set; }
        [Display(Name = "Precio de Venta")]
        public decimal mat_prec_ven { get; set; }
        [Display(Name = "Fecha")]
        public string mat_fec { get; set; }
        [Display(Name = "Estado")]
        public char mat_est { get; set; }
    }
}
