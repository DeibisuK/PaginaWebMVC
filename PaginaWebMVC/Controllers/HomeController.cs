using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaWebMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Resumen()
        {
            return View("Resumen");
        }

        public ActionResult Empleado()
        {
            return View("Empleado");
        }

        public ActionResult Cargos()
        {
            return View("Cargos");
        }
        public ActionResult Compras()
        {
            return View("Compras");
        }

        public ActionResult Recursos()
        {
            return View("Recursos");
        }

        public ActionResult Cliente()
        {
            return View("Cliente");
        }

        public ActionResult Proveedor()
        {
            return View("Proveedor");
        }
        public ActionResult Proyecto()
        {
            return View("Proyecto");
        }

        public ActionResult Servicio()
        {
            return View("Servicio");
        }

    }
}