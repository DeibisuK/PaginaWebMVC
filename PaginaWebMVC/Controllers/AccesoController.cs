using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaginaWebMVC.Models;
using System.Data;
using System.Data.SqlClient;

namespace PaginaWebMVC.Controllers
{
    public class AccesoController : Controller
    {
        static string cadena = "Data Source=´MACHINEGUN\\SQLEX´;initial catalog=PruebaLogin;integrated security=true";
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(Usuario user)
        {
            bool registrado;
            string mensaje;

            if (user.Contraseña == user.ConfirmarClave)
            {
                user.Contraseña = user.ConfirmarClave;
            }
            else
            {
                ViewData["Mensaje"] = "Las constraseñas no coinciden";
                return View();
            }

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_AgregarUsuario",cn);
                cmd.Parameters.AddWithValue("Nombre",user.Nombre);
                cmd.Parameters.AddWithValue("Email",user.Email);
                cmd.Parameters.AddWithValue("Contraseña",user.Contraseña);
            }

                return View();
        }
    }
}