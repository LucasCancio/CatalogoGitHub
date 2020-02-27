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
using Newtonsoft.Json;
using Catalogo_GitHub.ViewModel;

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
        public async Task<IActionResult> Catalogo(string userName= "skevy")
        {
            _repositorios = await _repositorioService.ListarRepositorios(userName);
            var model = new CatalogoViewModel()
            {
                repositorios = _repositorios,
                length = _repositorios.Count,
                pageSize = 9//Quantos por pagina
            };
            var totalPages = (double)model.length / model.pageSize;
            model.totalPages = (int)Math.Ceiling(totalPages);



            return View(model);
        }

        [HttpPost]
        public IActionResult ListarRepositorios(int pageNumber, int pageSize, string query = "")
        {
            try
            {
                var repositorios = !string.IsNullOrEmpty(query) ? (from repo in _repositorios
                                                                   where repo.name.ToUpper().Contains(query.ToUpper())
                                                                   select repo).ToList()
                                                           : _repositorios;

                var model = new CatalogoViewModel()
                {
                    length = repositorios.Count,
                    pageSize = 9//Quantos por pagina
                };

                var totalPages = (double)model.length / model.pageSize;
                model.totalPages = (int)Math.Ceiling(totalPages);

                repositorios = repositorios.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

                model.repositorios = repositorios;

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
