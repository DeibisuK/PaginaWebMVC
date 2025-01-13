using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaginaWebMVC.Models.DTO;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Web.Services.Description;
using PaginaWebMVC.Models;
using System.Data.Entity.Core.Objects;

namespace PaginaWebMVC.Controllers
{
    public class AccesoController : Controller
    {
        static string cadena = "Data Source=SQL1001.site4now.net;Initial catalog=db_ab16d0_constructorabd;User Id=db_ab16d0_constructorabd_admin;Password=cartuchin1";

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register() { 
            return View();
        }


        [HttpPost]
        public ActionResult Login(UsuarioDTO user)
        {
            
            return View();

            //if (user.usu_contra != null || user.usu_email != null)
            //{
            //    user.usu_contra = ConvertirSha256(user.usu_contra);

            //    using (SqlConnection cn = new SqlConnection(cadena))
            //    {
            //        SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", cn);
            //        cmd.Parameters.AddWithValue("Correo", user.usu_email);
            //        cmd.Parameters.AddWithValue("Contraseña", user.usu_contra);
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        cn.Open();
            //        user.usu_id = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            //        string sqlQuery = "SELECT usu_nom FROM dbo.usuarios WHERE usu_id = @UserId";
            //        cmd = new SqlCommand(sqlQuery, cn);
            //        cmd.Parameters.AddWithValue("@UserId", user.usu_id);

            //        user.usu_nom = cmd.ExecuteScalar()?.ToString();
            //    }

            //    if (user.usu_id != 0)
            //    {
            //        Session["usuario"] = user;
            //        Session["Nombre"] = user.usu_nom;
            //        return RedirectToAction("Resumen", "Home");
            //    }
            //    else
            //    {
            //        ViewData["MensajeLogin"] = "Usuario no encontrado";
            //        return View();
            //    }
            //}
            //else
            //{
            //    ViewData["MensajeLogin"] = "Rellena con tus datos";
            //    return View();
            //}
        }

        [HttpPost]
        public ActionResult Register(UsuarioDTO user)
        {
            using (ConstructoraBDEntities context = new ConstructoraBDEntities())
            {
                var idresultado = new ObjectParameter("IdUsuarioResultado", typeof(int));
                var mensaje = new ObjectParameter("Mensaje", typeof(string));
                user.usu_est = "H";

                context.SP_RegistrarUsuario(user.usu_nom, user.usu_email, user.usu_contra, user.usu_est, idresultado, mensaje);
                if ((int) idresultado.Value != 0)
                {
                    ViewData["MensajeRegsiter"] = mensaje.Value;
                    return View("Resumen", "Home");
                }
                else
                {
                    ViewData["MensajeRegsiter"] = mensaje.Value;
                    return View();
                }
            }
            //    bool registrado;
            //    string mensaje;
            //    try
            //    {
            //        if (user.usu_contra == user.usu_repeat)
            //        {
            //            user.usu_contra = ConvertirSha256(user.usu_contra);
            //        }
            //        else
            //        {
            //            ViewData["MensajeRegister"] = "Las constraseñas no coinciden";
            //            ViewData["MostrarRegistro"] = "active"; // Bandera para mostrar el registro.
            //            return View("Login");
            //        }

            //        using (SqlConnection cn = new SqlConnection(cadena))
            //        {
            //            SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", cn);
            //            cmd.Parameters.AddWithValue("usu_nom", user.usu_nom);
            //            cmd.Parameters.AddWithValue("usu_email", user.usu_email);
            //            cmd.Parameters.AddWithValue("usu_contra", user.usu_contra);
            //            cmd.Parameters.AddWithValue("usu_est", 'H');
            //            cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
            //            cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
            //            cmd.CommandType = CommandType.StoredProcedure;

            //            cn.Open();
            //            cmd.ExecuteNonQuery();

            //            registrado = Convert.ToBoolean(cmd.Parameters["IdUsuarioResultado"].Value);
            //            mensaje = cmd.Parameters["IdUsuarioResultado"].Value.ToString();
            //        }

            //        ViewData["MensajeRegister"] = mensaje;

            //        if (registrado)
            //        {
            //            return View("Login");
            //        }
            //        else
            //        {
            //            return View("Login");
            //        }
            //}
            //    catch (Exception)
            //    {
            //        ViewData["MensajeRegister"] = "Llena los datos";
            //        ViewData["MostrarRegistro"] = "active"; // Bandera para mostrar el registro.
            //        return View("Login");
            //}
        }

        public static string ConvertirSha256(string texto)
        {
            StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

    }
}