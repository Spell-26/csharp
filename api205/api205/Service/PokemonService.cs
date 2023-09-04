using api205.Models;

namespace api205.Service
{
    public class PokemonService
    {
        private readonly HttpClient _httpClient;
        public PokemonService(HttpClient httpClient)
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<Pokemon>> GetPokemons()
        {
            
            var response = await _httpClient.GetFromJsonAsync<PokemonApiResponse>("https://pokeapi.co/api/v2/pokemon");
            List<string> subResponse = new List<string>();
            int counter = 0;
            //PENDIENTE
            foreach(var respuesta in response.Results)
            {   
                if(respuesta != null)
                {
                    subResponse.Add(respuesta);
                }
                
            }
            return response.Results;
        }

        public class PokemonApiResponse
        {
            public IEnumerable<Pokemon> Results { get; set; }
        }
    }
}