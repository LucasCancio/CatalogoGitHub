using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo_GitHub.Models
{
    public class Repositorio
    {
        public string id { get; set; }
        public string name { get; set; }
        public string html_url { get; set; }
        public string url { get; set; }

        private string _contents_url;
        public string contents_url
        {
            get
            {
                return _contents_url;
            }
            set
            {
                _contents_url = value.Substring(0, value.IndexOf("contents")+8);
            }
        }


        public string description { get; set; }
        public string language { get; set; }
    }
}
