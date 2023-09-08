using api205.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace api205.Service
{
    public class PokemonService
    {
        private readonly HttpClient _httpClient;
        private const string PokeApiBaseUrl = "https://pokeapi.co/api/v2/";

  

        public PokemonService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(PokeApiBaseUrl);
        }

        public async Task<IEnumerable<PokemonInfo>> GetPokemon()
        {
            var response = await _httpClient.GetFromJsonAsync<PokemonListResponse>("pokemon");

            if(response != null && response.Results != null)
            {
                var pokemonInfoList = new List<PokemonInfo>();

                foreach(var result in response.Results)
                {
                    var pokemonDetails = await _httpClient.GetFromJsonAsync<PokemonDetailsResponse>(result.url);
           

                    if(pokemonDetails != null)
                    {
                        // Extraer la URL de la imagen del objeto de detalles del Pokémon.
                        string imageUrl = pokemonDetails.sprites.front_default;


                        // Crear un objeto PokemonInfo que contenga el nombre y la URL de la imagen.
                        var pokemonInfo = new PokemonInfo
                        {
                            Name = result.name,
                            ImageUrl = imageUrl
                        };

                        pokemonInfoList.Add(pokemonInfo);
                    }
                }

                return pokemonInfoList;
            }
            return null;
        }
    }




        public class PokemonListResponse
        {
            public List<Pokemon> Results { get; set; }
        }

        public class PokemonDetailsResponse
        {
           
            public PokemonSprites sprites { get; set; }
        }
        public class PokemonSprites
        {
         
            public string front_default { get; set; }

            // Otras propiedades de imágenes del Pokémon...
        }

}