using Catalogo_GitHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_GitHub.Interfaces.Services
{
    public interface IConteudoService
    {
        Task<List<Conteudo>> ListarConteudos(string userName, string repositorioName, string path);
        Task<Arquivo> ConsultarArquivo(string userName, string repositorioName, string path);
    }
}
