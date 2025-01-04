using PaginaWebMVC.Models;
using PaginaWebMVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaWebMVC.Controllers.CargosController
{
    public class CargosController : Controller
    {
        // GET: Cargos
        public ActionResult Cargos()
        {
            List<Cargos> listCargos;
            using (ConstructoraBDEntities context = new ConstructoraBDEntities())
            {
                listCargos = (from c in context.cargos
                              select new Cargos()
                            {
                                cargo_id = c.cargo_id,
                                cargo_nom = c.cargo_nom
                            }).ToList();
            }

            return View();
        }

        // GET: Cargos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cargos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cargos/Create
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

        // GET: Cargos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cargos/Edit/5
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

        // GET: Cargos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cargos/Delete/5
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
