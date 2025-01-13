using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Constructora.Entidades
{
    public class VentasDTO
    {
        [Display(Name = "ID")]
        public int ven_id { get; set; }
        [Display(Name = "Cliente")]
        public int Cliente_Id { get; set; }
        [Display(Name = "Cliente")]
        public string Cliente_Nombre { get; set; }
        [Display(Name = "Pago")]
        public int Pago_Id { get; set; }
        [Display(Name = "Pago")]
        public string Pago_Nombre { get; set; }
        [Display(Name = "Tipo de Documento")]
        public string ven_tip_doc { get; set; }
        [Display(Name = "Número de Documento")]
        public string ven_num_doc { get; set; }
        [Display(Name = "Monto de Pago")]
        public decimal ven_mont_pag { get; set; }
        [Display(Name = "Monto de Cambio")]
        public decimal ven_mont_camb { get; set; }
        [Display(Name = "Monto Total")]
        public decimal ven_mont_tot { get; set; }
        [Display(Name = "Fecha")]
        public string ven_fec { get; set; }
        [Display(Name = "Estado")]
        public char ven_est { get; set; }

    }
}
