using Catalogo_GitHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_GitHub.ViewModel
{
    public class CatalogoViewModel
    {
        public List<Repositorio> repositorios { get; set; }
        public int length { get; set; }
        public int pageSize { get; set; }
        public int totalPages { get; set; }
    }
}
