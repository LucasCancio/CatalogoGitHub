using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_GitHub.Models
{
    public class RepositorioViewModel
    {
        public Repositorio repositorio { get; set; }
        public List<Conteudo> conteudos { get; set; }
    }
    
}
