using Catalogo_GitHub.Interfaces.Services;
using Catalogo_GitHub.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Catalogo_GitHub.Services
{
    public class ConteudoService : IConteudoService
    {
        private HttpClient _httpClient;
        public ConteudoService()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.github.com")
            };
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "request");
        }

        public async Task<List<Conteudo>> ListarConteudos(string userName, string repositorioName, string path)
        {
            path += "?ref=master";

            var uri = $"repos/{userName}/{repositorioName}/contents/{path}";
            var json = await Get(uri);

            var contents = JsonConvert.DeserializeObject<List<Conteudo>>(json);

            return contents;
        }

        public async Task<Arquivo> ConsultarArquivo(string userName, string repositorioName, string path)
        {
            path += "?ref=master";

            var uri = $"repos/{userName}/{repositorioName}/contents/{path}";
            var json = await Get(uri);

            var arquivo = JsonConvert.DeserializeObject<Arquivo>(json);

            return arquivo;
        }

        private async Task<string> Get(string uri)
        {
            try
            {
                System.Net.Http.HttpResponseMessage response;

                response = await _httpClient.GetAsync(uri);

                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
