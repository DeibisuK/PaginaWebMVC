using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaWebMVC.Controllers
{
    public class ResumenController : Controller
    {
        // GET: Resumen
        public ActionResult Index()
        {
            return View();
        }

        // GET: Resumen/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Resumen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resumen/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Resumen/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Resumen/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Resumen/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Resumen/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
