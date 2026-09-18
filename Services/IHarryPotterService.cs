using ChuckNorris.Models;
using System.Net.Http.Json;

namespace ChuckNorris.Services
{
    public interface IHarryPotterService
    {
        Task<HarryPotterCharacter> ObterPersonagemAleatorioAsync();
    }

    public class HarryPotterService : IHarryPotterService
    {
        private readonly HttpClient _httpClient;

        public HarryPotterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HarryPotterCharacter> ObterPersonagemAleatorioAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<HarryPotterCharacter>("en/characters/random");
            }
            catch
            {
                return null;
            }
        }
    }
}