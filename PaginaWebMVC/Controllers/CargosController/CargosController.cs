using PaginaWebMVC.Models;
using PaginaWebMVC.Models.DTO;
using PaginaWebMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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
            List <CargosDTO> listCargos;
            using (ConstructoraBDEntities context = new ConstructoraBDEntities())
            {
                listCargos = (from c in context.cargos
                              select new CargosDTO()
                              {
                                  cargo_id = c.cargo_id,
                                  cargo_nom = c.cargo_nom
                              }).ToList();
            }

            // Crear el ViewModel
            var model = new GetCargosVM
            {
                cargos = listCargos, // Asignar la lista de cargos
                newCargo = new CargosDTO() // Crear un nuevo modelo vacío para el formulario de creación
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

                var dto = new CargosDTO()
                {
                    cargo_id = entity.cargo_id,
                    cargo_nom = entity.cargo_nom
                };

                // Retorna una vista parcial en lugar de una vista completa
                return PartialView("Details", dto);
            }
        }

        // GET: Cargos/Create
        public ActionResult Create()
        {
            using (ConstructoraBDEntities context = new ConstructoraBDEntities())
            {
                int nextId = Convert.ToInt32(context.Database.SqlQuery<decimal>("SELECT IDENT_CURRENT('cargos') + IDENT_INCR('cargos')").FirstOrDefault());
                ViewBag.NextId = nextId;
            }

            return PartialView("Create");
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
                        var resultado = new ObjectParameter("Resultado", typeof(int));
                        var mensaje = new ObjectParameter("Mensaje", typeof(string));
                        context.SP_RegistrarCargo(model.newCargo.cargo_nom, resultado, mensaje);
                        
                        // Verificar el resultado y mensaje
                        if ((int)resultado.Value > 0)
                        {
                            // Registro exitoso
                            TempData["Success"] = "Cargo registrado correctamente.";
                            context.SaveChanges();
                        }
                        else
                        {
                            // Error en el registro
                            TempData["Error"] = mensaje.Value.ToString();
                        }
                    }
                    //using (ConstructoraBDEntities context = new ConstructoraBDEntities())
                    //{
                    //    context.cargos.Add(new cargos()
                    //    {
                    //        cargo_nom = model.newCargo.cargo_nom // Usamos el cargo del modelo de creación
                    //    });
                    //    context.SaveChanges();
                    //}
                    //// Redirigir a la acción que lista los cargos
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

                var dto = new CargosDTO()
                {
                    cargo_id = entity.cargo_id,
                    cargo_nom = entity.cargo_nom
                };

                return PartialView("Edit", dto);
            }
        }

        // POST: Cargos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CargosDTO cargo)
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
                    return HttpNotFound();
                }

                var dto = new CargosDTO()
                {
                    cargo_id = entity.cargo_id,
                    cargo_nom = entity.cargo_nom
                };

                return PartialView("Delete", dto);
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
        //public ActionResult RenderPartial(string partialName, int id)
        //{
        //    using (ConstructoraBDEntities context = new ConstructoraBDEntities())
        //    {
        //        switch (partialName)
        //        {
        //            case "Editar":
        //                var editModel = context.cargos
        //                    .Where(x => x.cargo_id == id)
        //                    .Select(x => new Cargos
        //                    {
        //                        cargo_id = x.cargo_id,
        //                        cargo_nom = x.cargo_nom
        //                    })
        //                    .FirstOrDefault();

        //                if (editModel == null)
        //                {
        //                    return HttpNotFound(); // Si no se encuentra el cargo
        //                }

        //                return PartialView("Edit", editModel);

        //            case "Detalles":
        //                var detailsModel = context.cargos
        //                    .Where(x => x.cargo_id == id)
        //                    .Select(x => new Cargos
        //                    {
        //                        cargo_id = x.cargo_id,
        //                        cargo_nom = x.cargo_nom
        //                    })
        //                    .FirstOrDefault();

        //                if (detailsModel == null)
        //                {
        //                    return HttpNotFound(); // Si no se encuentra el cargo
        //                }

        //                return PartialView("Details", detailsModel);

        //            case "Eliminar":
        //                var deleteModel = context.cargos
        //                    .Where(x => x.cargo_id == id)
        //                    .Select(x => new Cargos
        //                    {
        //                        cargo_id = x.cargo_id,
        //                        cargo_nom = x.cargo_nom
        //                    })
        //                    .FirstOrDefault();

        //                if (deleteModel == null)
        //                {
        //                    return HttpNotFound(); // Si no se encuentra el cargo
        //                }

        //                return PartialView("Delete", deleteModel);

        //            default:
        //                return PartialView("Create");
        //        }
        //    }
        //}

    }
}
