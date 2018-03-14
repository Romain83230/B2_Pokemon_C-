using System;

namespace TP1_Pokemon
{
    public class PokemonLegendary : Pokemon
    {
        public PokemonLegendary(string nomPokemon, int atk1, int atk2, int atk3, int atk4)
        {
            this.nomPokemon = nomPokemon;
            this.ptsVie = 300;
            this.atk1 = atk1 * 2 + 10;
            this.atk2 = atk2 * 2 + 10;
            this.atk3 = atk3 * 2 + 10;
            this.atk4 = atk4 * 2 + 10;
        }
    }
}