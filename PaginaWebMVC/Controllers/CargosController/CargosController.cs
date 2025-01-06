using PaginaWebMVC.Models;
using PaginaWebMVC.Models.DTO;
using PaginaWebMVC.ViewModels;
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
            
            // Obtener la lista de cargos desde la base de datos
            List <Cargos> listCargos;
            using (ConstructoraBDEntities context = new ConstructoraBDEntities())
            {
                listCargos = (from c in context.cargos
                              select new Cargos()
                              {
                                  cargo_id = c.cargo_id,
                                  cargo_nom = c.cargo_nom
                              }).ToList();
            }

            // Crear el ViewModel
            var model = new GetCargosVM
            {
                cargos = listCargos, // Asignar la lista de cargos
                newCargo = new Cargos() // Crear un nuevo modelo vacío para el formulario de creación
            };

            return View(model); // Pasar el ViewModel a la vista
        }

        // GET: Cargos/Details/5
        public ActionResult Details(int id)
        {
            using (ConstructoraBDEntities context = new ConstructoraBDEntities())
            {
                var entity = context.cargos.SingleOrDefault(x => x.cargo_id == id);

                if (entity == null)
                {
                    return HttpNotFound(); // Retorna 404 si no se encuentra
                }

                var dto = new Cargos()
                {
                    cargo_id = entity.cargo_id,
                    cargo_nom = entity.cargo_nom
                };

                return View(dto);
            }
        }

        // GET: Cargos/Create
        public ActionResult Create()
        {
            using (ConstructoraBDEntities context = new ConstructoraBDEntities())
            {
                // Obtener el próximo ID solo para mostrarlo (no se enviará al servidor)
                int nextId = Convert.ToInt32(context.Database.SqlQuery<decimal>("SELECT IDENT_CURRENT('cargos') + IDENT_INCR('cargos')").FirstOrDefault());

                // Pasar el ID calculado como ViewBag (o ViewData)
                ViewBag.NextId = nextId;
            }
            return View();
        }

        // POST: Cargos/Create
        [HttpPost]
        public ActionResult Create(GetCargosVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (ConstructoraBDEntities context = new ConstructoraBDEntities())
                    {
                        context.cargos.Add(new cargos()
                        {
                            cargo_nom = model.newCargo.cargo_nom // Usamos el cargo del modelo de creación
                        });
                        context.SaveChanges();
                    }

                    // Redirigir a la acción que lista los cargos
                    return RedirectToAction("Cargos");
                }

                // Si el modelo no es válido, volvemos a mostrar la vista con errores
                return View("Cargos", model);
            }
            catch
            {
                return View();
            }
        }


        // GET: Cargos/Edit/5
        public ActionResult Edit(int id)
        {
            using (ConstructoraBDEntities context = new ConstructoraBDEntities())
            {
                var entity = context.cargos.SingleOrDefault(x => x.cargo_id == id);

                if (entity == null)
                {
                    return HttpNotFound(); // Retorna 404 si no se encuentra
                }

                var dto = new Cargos()
                {
                    cargo_id = entity.cargo_id,
                    cargo_nom = entity.cargo_nom
                };

                return View(dto);
            }
        }

        // POST: Cargos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cargos cargo)
        {
            try
            {
                using (ConstructoraBDEntities context = new ConstructoraBDEntities())
                {
                    // Obtener la entidad existente de la base de datos
                    var entity = context.cargos.SingleOrDefault(x => x.cargo_id == id);

                    if (entity == null)
                    {
                        return HttpNotFound(); // Retorna un error 404 si no encuentra el registro
                    }

                    // Actualizar las propiedades de la entidad con los valores del DTO
                    entity.cargo_nom = cargo.cargo_nom;

                    // Guardar los cambios en la base de datos
                    context.SaveChanges();
                }
                // Redirigir a la lista de cargos después de la edición
                return RedirectToAction("Cargos");
            }
            catch
            {
                // Si hay un error, volver a la vista de edición con el modelo actual
                return View(cargo);
            }
        }

        // GET: Cargos/Delete/5
        public ActionResult Delete(int id)
        {
            using (ConstructoraBDEntities context = new ConstructoraBDEntities())
            {
                var entity = context.cargos.SingleOrDefault(x => x.cargo_id == id);

                if (entity == null)
                {
                    return HttpNotFound(); // Retorna 404 si no se encuentra
                }

                var dto = new Cargos()
                {
                    cargo_id = entity.cargo_id,
                    cargo_nom = entity.cargo_nom
                };

                return View(dto);
            }
        }

        // POST: Cargos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (ConstructoraBDEntities context = new ConstructoraBDEntities())
                {
                    var entity = context.cargos.SingleOrDefault(x => x.cargo_id == id);
                    context.cargos.Remove(entity);
                    context.SaveChanges();
                }

                    return RedirectToAction("Cargos");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult RenderPartial(string partialName, int id)
        {
            switch (partialName)
            {
                case "Editar":
                    return PartialView("Edit", id);
                case "Details":
                    return PartialView("Details", id); // Ejemplo
                case "Eliminar":
                    return PartialView("Detele", id); // Ejemplo
                default:
                    return PartialView("Create");
            }
        }
    }
}
