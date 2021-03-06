﻿using Catalogo_GitHub.Interfaces.Services;
using Catalogo_GitHub.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Catalogo_GitHub.Services
{
    public class RepositorioService : IRepositorioService
    {
        private HttpClient _httpClient;
        public RepositorioService()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.github.com")
            };
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "request");
        }
        public async Task<List<Repositorio>> ListarRepositorios(string userName)
        {
            var uri = $"users/{userName}/repos";
            var json = await Get(uri);

            var repositorios = JsonConvert.DeserializeObject<List<Repositorio>>(json);

            return repositorios;
        }

        public async Task<Repositorio> ConsultarRepositorio(string userName, string repositorioName)
        {
            var json = await Get($"repos/{userName}/{repositorioName}");

            var repositorio = JsonConvert.DeserializeObject<Repositorio>(json);

            return repositorio;
        }

        public async Task<List<Conteudo>> ConsultarContentUrl(string url)
        {
            var json = await Get(url);

            var conteudos = JsonConvert.DeserializeObject<List<Conteudo>>(json);

            return conteudos;
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
