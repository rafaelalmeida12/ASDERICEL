using AtletaAsdericel.Models;

namespace AtletaAsdericel.Services
{
    public class CorreiosService
    {
        private readonly HttpClient _httpClient;

        public CorreiosService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Endereco> BuscarEnderecoPorCep(string cep)
        {
            var response = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            response.EnsureSuccessStatusCode();

            var endereco = await response.Content.ReadFromJsonAsync<Endereco>();
            return endereco;
        }
    }
}
