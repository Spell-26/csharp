using api205.Service;
using Microsoft.AspNetCore.Mvc;

namespace api205.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonService _pokemonService;

        public PokemonController(PokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pokemons = await _pokemonService.GetPokemon();
            return View(pokemons);
        }
    }
}
