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

        private static Repositorio _repositorio= new Repositorio();

        public RepositorioController()
        {
            _repositorioService = new RepositorioService();
            _conteudoService = new ConteudoService();
        }

        [Route("{userName}/{repositorioName}")]
        public async Task<ActionResult> Index(string userName,string repositorioName)
        {
            if (_repositorio.name != repositorioName)
                _repositorio = await _repositorioService.ConsultarRepositorio(userName, repositorioName);

            var conteudos = await _repositorioService.ConsultarContentUrl(_repositorio.contents_url);

            var repositorioViewModel = new RepositorioViewModel()
            {
                repositorio=_repositorio,
                conteudos = conteudos
            };

            return View(repositorioViewModel);
        }

        [Route("{userName}/{repositorioName}/dir/{*path}")]
        public async Task<IActionResult> Conteudo(string userName, string repositorioName, string path)
        {
            try
            {
                if (_repositorio.name != repositorioName)
                    _repositorio = await _repositorioService.ConsultarRepositorio(repositorioName, userName);

                var conteudos = await _conteudoService.ListarConteudos(userName, repositorioName, path);

                var model = new RepositorioViewModel()
                {
                    repositorio=_repositorio,
                    conteudos=conteudos
                };

                return View("Index", model);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }

        }
        [HttpPost]
        //[Route("{userName}/{repositorioName}/file/{*path}")]
        [Route("{userName}/{repositorioName}/file")]
        public async Task<IActionResult> Arquivo(string userName, string repositorioName, string path)
        {
            try
            {
                //var path = HttpContext.Session.GetString("path");

                if (_repositorio.name != repositorioName)
                    _repositorio = await _repositorioService.ConsultarRepositorio(repositorioName, userName);

                var arquivo = await _conteudoService.ConsultarArquivo(userName, repositorioName, path);

                var model = new ArquivoViewModel()
                {
                    repositorio = _repositorio,
                    arquivo = arquivo
                };

                return View(model);
            }
            catch (Exception ex)
            {
                return BadRequest("Erro: " + ex.Message);
            }

        }
    }
}