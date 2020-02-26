using Catalogo_GitHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_GitHub.Interfaces.Services
{
    interface IRepositorioService
    {
        Task<List<Repositorio>> ListarRepositorios(string userName);
        Task<Repositorio> ConsultarRepositorio(string userName, string repositorioName);
        Task<List<Conteudo>> ConsultarContentUrl(string url);
    }
}
