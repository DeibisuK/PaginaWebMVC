using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PaginaWebMVC.Models;
using PaginaWebMVC.Permisos;

namespace PaginaWebMVC.Controllers
{
    [ValidarSesion]
    public class HomeController : Controller
    {
        

        // GET: Home
        public ActionResult Resumen()
        {
            ViewBag.Title = "Resumen";
            return View("Resumen");
        }

        public ActionResult Empleado()
        {
            ViewBag.Title = "Empleados";
            return View("Empleado");
        }

        public ActionResult Cargos()
        {
            ViewBag.Title = "Cargos";
            return View("Cargos");
        }
        public ActionResult Compras()
        {
            ViewBag.Title = "Compras";
            return View("Compras");
        }

        public ActionResult Recursos()
        {ViewBag.Title = "Recursos";
            return View("Recursos");
        }

        public ActionResult Cliente()
        {ViewBag.Title = "Cliente";
            return View("Cliente");
        }

        public ActionResult Proveedor()
        {ViewBag.Title = "Proveedor";
            return View("Proveedor");
        }
        public ActionResult Proyecto()
        {ViewBag.Title = "Proyecto";
            return View("Proyecto");
        }

        public ActionResult Servicio()
        {ViewBag.Title = "Servicio";
            return View("Servicio");
        }

        public ActionResult CerrarSesion()
        {
            Session["usuario"] = null;
            return RedirectToAction("Login","Acceso");
        }
    }
}