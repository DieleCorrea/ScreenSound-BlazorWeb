﻿using ScreamSound.Web.Response;
using System.Net.Http.Json;

namespace ScreamSound.Web.Services
{
    public class ArtistaAPI
    {
       private readonly HttpClient _httpClient;

        public ArtistaAPI(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("API");
        }

        public async Task<ICollection<ArtistaResponse>?> GetArtistasAsync()
        {
            return await _httpClient.GetFromJsonAsync<ICollection<ArtistaResponse>>("artistas");
        }
    }
}
