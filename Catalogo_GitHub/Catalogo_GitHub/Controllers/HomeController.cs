using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Catalogo_GitHub.Models;
using Catalogo_GitHub.Services;
using Catalogo_GitHub.Interfaces.Services;

namespace Catalogo_GitHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioService _repositorioService;
        private static List<Repositorio> _repositorios;

        public HomeController()
        {
            _repositorioService = new RepositorioService();
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Catalogo()
        {
            _repositorios = await _repositorioService.ListarRepositorios("lucascancio");
            return View();
        }
        [HttpPost]

        public IActionResult ListarRepositorios(string query = "")
        {
            try
            {
                //List<Repositorio> repositorios = (List<Repositorio>)TempData["repositorios"];

                var model = !string.IsNullOrEmpty(query) ? (from repo in _repositorios
                                                           where repo.name.ToUpper().Contains(query.ToUpper())
                                                           select repo).ToList()
                                                           : _repositorios;

                return PartialView("_Repositorios", model);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
