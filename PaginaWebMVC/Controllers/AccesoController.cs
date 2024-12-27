using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaginaWebMVC.Models;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Web.Services.Description;

namespace PaginaWebMVC.Controllers
{
    public class AccesoController : Controller
    {
        static string cadena = "Data Source=DESKTOP-V0DHSV8;initial catalog=PruebaLogin;integrated security=true";
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register() { 
            return View();
        }


        [HttpPost]
        public ActionResult Login(Usuario user)
        {
            if (user.Clave != null || user.Correo != null)
            {
                user.Clave = ConvertirSha256(user.Clave);

                using (SqlConnection cn = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", cn);
                    cmd.Parameters.AddWithValue("Correo", user.Correo);
                    cmd.Parameters.AddWithValue("Contraseña", user.Clave);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    user.Id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                }

                if (user.Id != 0)
                {
                    Session["usuario"] = user;
                    return RedirectToAction("Resumen", "Home");
                }
                else
                {
                    ViewData["MensajeLogin"] = "Usuario no encontrado";
                    return View();
                }
            }
            else
            {
                ViewData["MensajeLogin"] = "Rellena con tus datos";
                return View();
            }
        }

        [HttpPost]
        public ActionResult Register(Usuario user)
        {
            bool registrado;
            string mensaje;


            //try {
                if (user.Clave == user.ConfirmarClave)
                {
                    user.Clave = ConvertirSha256(user.Clave);
                }
                else
                {
                    ViewData["MensajeRegister"] = "Las constraseñas no coinciden";
                    ViewData["MostrarRegistro"] = "active"; // Bandera para mostrar el registro.
                    return View("Login");
                }

                using (SqlConnection cn = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", cn);
                    cmd.Parameters.AddWithValue("Nombre", user.Nombre);
                    cmd.Parameters.AddWithValue("Correo", user.Correo);
                    cmd.Parameters.AddWithValue("Contraseña", user.Clave);
                    cmd.Parameters.Add("Registrado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    registrado = Convert.ToBoolean(cmd.Parameters["Registrado"].Value);
                    mensaje = cmd.Parameters["Registrado"].Value.ToString();
                }

                ViewData["MensajeRegister"] = mensaje;

                if (registrado)
                {
                    return View("Login");
                }
                else
                {
                    return View("Login");
                }
            
            //catch (Exception)
            //{
            //    ViewData["MensajeRegister"] = "Llena los datos";
            //    ViewData["MostrarRegistro"] = "active"; // Bandera para mostrar el registro.
            //    return View("Login");
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