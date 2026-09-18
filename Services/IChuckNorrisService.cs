using ChuckNorris.Models;
using System.Net.Http.Json;

namespace ChuckNorris.Services
{
    public interface IChuckNorrisService
    {
        Task<ChuckNorrisJoke> ObterPiadaAleatoriaAsync();
    }

    public class ChuckNorrisService : IChuckNorrisService
    {
        private readonly HttpClient _httpClient;

        public ChuckNorrisService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ChuckNorrisJoke> ObterPiadaAleatoriaAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<ChuckNorrisJoke>("jokes/random");
            }
            catch
            {
                return null;
            }
        }
    }
}