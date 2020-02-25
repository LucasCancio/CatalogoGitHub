using Catalogo_GitHub.Interfaces.Services;
using Catalogo_GitHub.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalogo_GitHub.Controllers
{
    public class RepositorioController : Controller
    {
        private readonly IRepositorioService _repositorioService;

        public RepositorioController()
        {
            _repositorioService = new RepositorioService();
        }
        // GET: Repositorio
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Consultar(string url)
        {
            _repositorioService.ConsultarRepositorio(url);
            return View();
        }

        // GET: Repositorio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Repositorio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Repositorio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Repositorio/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Repositorio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Repositorio/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}