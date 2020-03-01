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
using Microsoft.AspNetCore.Http;

namespace Catalogo_GitHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioService _repositorioService;

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
            var repositorios = await _repositorioService.ListarRepositorios(userName);
            HttpContext.Session.SetString("repositorios", JsonConvert.SerializeObject(repositorios));

            var model = new CatalogoViewModel()
            {
                repositorios = repositorios,
                length = repositorios.Count,
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
                var json = HttpContext.Session.GetString("repositorios");
                var repositorios = JsonConvert.DeserializeObject<List<Repositorio>>(json);

                if (!string.IsNullOrEmpty(query))
                {
                    repositorios = (from repo in repositorios
                                    where repo.name.ToUpper().Contains(query.ToUpper())
                                    select repo).ToList();
                }

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
