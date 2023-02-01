using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly DBRecetasContext context;
        public RecetaController(DBRecetasContext contex)
        {
            this.context = contex;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var recetas = context.Recetas.ToList();
            return View(recetas);
        }


        [HttpGet]
        public IActionResult IndexByNombre(string nombre)
        {
            var recetas = (from r in context.Recetas
                           where r.NombreAutor == nombre
                           select r).ToList();
            return View("Index", recetas);
        }

        [HttpGet]
        public IActionResult IndexByApellido(string apellido)
        {
            var recetas = (from r in context.Recetas
                           where r.ApellidoAutor == apellido
                           select r).ToList();
            return View("Index", recetas);
        }


        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();

            return View(receta);
        }

        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", receta);

        }



        [HttpGet]
        public ActionResult Delete(int id)
        {
            var receta = context.Recetas.Find(id);

            if (receta == null) { return NotFound(); }
            else { return View("Delete", receta); }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var receta = context.Recetas.Find(id);
            if (receta == null) return NotFound();
            else
            {
                context.Recetas.Remove(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }



        [HttpGet]
        public ActionResult Detail(int id)
        {
            var receta = context.Recetas.Find(id);
            if (receta == null) return NotFound();
            else return View("Detail", receta);
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var receta = context.Recetas.Find(id);
            if (receta == null) return NotFound();
            else return View("Edit", receta);

        }
        [HttpPost]
        public ActionResult Edit(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Entry(receta).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else return View("Edit", receta);
        }
    }

}
