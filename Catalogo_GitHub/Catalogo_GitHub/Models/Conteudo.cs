﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_GitHub.Models
{
    public class Conteudo
    {
        public string name { get; set; }
        public string path { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string type { get; set; }
        public Arquivo file { get; set; }
    }
}
