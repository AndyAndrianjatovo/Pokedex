using Dex.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dex.Util
{
    public class PokeClient
    {
        private HttpClient Client { get; }

        public PokeClient(HttpClient client)
        {
            this.Client = client;
        }

        public async Task<Pokemon?> GetPokemon(string id)
        {
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}/");
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Pokemon>(content);
        }
        
        public async Task<Pokemon?> GetAllPokemon()
        {
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon?limit=100000&offset=0");
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Pokemon>(content);
        }

        public async Task<List<Pokemon>> FetchKantoPokemonAsync()
        {
            List<Pokemon> pokemonList = new List<Pokemon>();
            var response = await this.Client.GetAsync("https://pokeapi.co/api/v2/pokemon?limit=151");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                PokemonList? allPokemon = JsonSerializer.Deserialize<PokemonList>(json);

                foreach (var pokemon in allPokemon.results)
                {
                    pokemonList.Add(await FetchPokemonDataAsync(pokemon));
                }

                return pokemonList;
            }
            else
            {
                Console.WriteLine("Erreur lors de la récupération des données.");
                return null;
            }
            
        }

        public async Task<List<Pokemon>> FetchKantoPokemonAsync(int limit, int offset)
        {
            List<Pokemon> pokemonList = new List<Pokemon>();
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon?limit={limit}&offset={offset}");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                PokemonList? allPokemon = JsonSerializer.Deserialize<PokemonList>(json);

                foreach (var pokemon in allPokemon.results)
                {
                    pokemonList.Add(await FetchPokemonDataAsync(pokemon));
                }

                return pokemonList;
            }
            else
            {
                Console.WriteLine("Erreur lors de la récupération des données.");
                return null;
            }
        }


        public async Task<Pokemon?> FetchPokemonDataAsync(PokemonData pokemon)
        {
            var response = await this.Client.GetAsync(pokemon.url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<Pokemon>(json);
            }
            else
            {
                Console.WriteLine($"Erreur lors de la récupération des données du Pokémon {pokemon.name}.");
                return null;
            }
        }
    }

    public class PokemonData
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokemonList
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public PokemonData[] results { get; set; }
    }
}
