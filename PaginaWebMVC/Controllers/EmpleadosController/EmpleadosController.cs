using PaginaWebMVC.Models;
using PaginaWebMVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaWebMVC.Controllers.EmpleadoController
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Empleado()
        {
            List<Empleados> listEmpleados;
            using (ConstructoraBDEntities context = new ConstructoraBDEntities())
            {
                listEmpleados = (from e in context.empleados
                                join ca in context.cargos on e.cargo_id equals ca.cargo_id
                                join ci in context.ciudad on e.ciu_id equals ci.ciu_id
                                 select new Empleados()
                                {
                                    emp_id = e.emp_id,
                                    emp_ced = e.emp_ced,
                                    emp_nom = e.emp_nom,
                                    emp_ape = e.emp_ape,
                                    cargo_id = ca.cargo_nom,
                                    emp_salario = (double) e.emp_salario,
                                    ciu_id = ci.ciu_nom,
                                    emp_fec_contrat = (DateTime) e.emp_fec_contrat,
                                    emp_tel = e.emp_tel,
                                    emp_est = e.emp_est

                                }).ToList();
            }
            return View(listEmpleados);
        }

        // GET: Empleados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Empleados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
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

        // GET: Empleados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empleados/Edit/5
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

        // GET: Empleados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empleados/Delete/5
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
