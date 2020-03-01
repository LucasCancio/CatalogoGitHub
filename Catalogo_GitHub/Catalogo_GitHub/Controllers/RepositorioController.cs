using Catalogo_GitHub.Interfaces.Services;
using Catalogo_GitHub.Models;
using Catalogo_GitHub.Services;
using Catalogo_GitHub.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Catalogo_GitHub.Controllers
{
    [Route("[controller]")]
    public class RepositorioController : Controller
    {
        private readonly IRepositorioService _repositorioService;
        private readonly IConteudoService _conteudoService;


        public RepositorioController()
        {
            _repositorioService = new RepositorioService();
            _conteudoService = new ConteudoService();
        }

        [Route("{userName}/{repositorioName}")]
        public async Task<ActionResult> Index(string userName, string repositorioName)
        {
            var repositorio = await getRepository(userName, repositorioName);

            var conteudos = await _repositorioService.ConsultarContentUrl(repositorio.contents_url);

            var repositorioViewModel = new RepositorioViewModel()
            {
                repositorio = repositorio,
                conteudos = conteudos
            };

            return View(repositorioViewModel);
        }

        [Route("{userName}/{repositorioName}/dir/{*path}")]
        public async Task<IActionResult> Conteudo(string userName, string repositorioName, string path)
        {
            try
            {
                var repositorio = await getRepository(userName, repositorioName);

                var conteudos = await _conteudoService.ListarConteudos(userName, repositorioName, path);

                var model = new RepositorioViewModel()
                {
                    repositorio = repositorio,
                    conteudos = conteudos
                };

                return View("Index", model);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }

        }
        [HttpPost]
        [Route("{userName}/{repositorioName}/file")]
        public async Task<IActionResult> Arquivo(string userName, string repositorioName, string path)
        {
            try
            {
                var repositorio = await getRepository(userName, repositorioName);

                var arquivo = await _conteudoService.ConsultarArquivo(userName, repositorioName, path);

                var model = new ArquivoViewModel()
                {
                    repositorio = repositorio,
                    arquivo = arquivo
                };

                return View(model);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }

        }

        private async Task<Repositorio> getRepository(string userName, string repositorioName)
        {
            var repositorio = new Repositorio();
            var json = HttpContext.Session.GetString("repositorio");
            if (string.IsNullOrEmpty(json))
            {
                repositorio = await _repositorioService.ConsultarRepositorio(userName, repositorioName);
                json = JsonConvert.SerializeObject(repositorio);
                HttpContext.Session.SetString("repositorio", json);
            }
            else
            {
                repositorio = JsonConvert.DeserializeObject<Repositorio>(json);
                if (repositorio.name != repositorioName)
                {
                    repositorio = await _repositorioService.ConsultarRepositorio(userName, repositorioName);
                    json = JsonConvert.SerializeObject(repositorio);
                    HttpContext.Session.SetString("repositorio", json);
                }

            }

            return repositorio;
        }
    }
}