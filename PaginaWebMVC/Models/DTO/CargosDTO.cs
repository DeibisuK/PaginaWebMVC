using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace PaginaWebMVC.Models.DTO
{
    public class CargosDTO
    {
        [Display(Name = "ID")]
        public int cargo_id { get; set; }
        [Display(Name = "Nombre")]
        public string cargo_nom { get; set; }


        public List<CargosDTO> Listar(string text)
        {
            using ()
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", cn);
                cmd.Parameters.AddWithValue("Correo", user.Correo);
                cmd.Parameters.AddWithValue("Contraseña", user.Clave);
                cmd.CommandType = CommandType.StoredProcedure;
            }
        }
    }
}