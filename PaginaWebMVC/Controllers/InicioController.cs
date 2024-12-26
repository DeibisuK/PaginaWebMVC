using PaginaWebMVC.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaWebMVC.Controllers
{
    [ValidarSesion]
    public class InicioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CerrarSesion()
        {
            Session["usuario"] = null;

            return RedirectToAction("Login","Acceso");
        }

    }
}