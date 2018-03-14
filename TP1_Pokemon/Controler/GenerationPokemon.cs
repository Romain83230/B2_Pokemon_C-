using System;
using System.IO;


namespace TP1_Pokemon
{
    public class GenerationPokemon
    {
        public static Boolean legendaire = false;
        private static Pokemon[] pokemons = new Pokemon[6];
        private String[][] nomPokemons = new String[2][];
        private static Pokemon[] pokemon;


        // attaque
        int[] Atk1 =
        {
            14, 9, 12, 32, 20, 10
        };

        //Defense
        int[] Atk2 =
        {
            8, 16, 18, 27, 20, 6
        };

        // Psy
        int[] Atk3 =
        {
            7, 10, 15, 33, 23, 20
        };

        //Def Psy
        int[] Atk4 =
        {
            17, 7, 16, 30, 14, 7
        };


        public GenerationPokemon()
        {
            if (legendaire)
            {
                nomPokemons[0] = new String[6] {"Artiquodin", "New", "Sulfura", "Mewtow", "Elecktor", "Locklass"};
                Pokemons(nomPokemons[0]);
            }
            else
            {
                nomPokemons[0] = new String[6]
                    {"Dracaufeu", "Florizarre", "Tortank", "Dracaulosse", "Rondoudou", "Akwakwak"};
                Pokemons(nomPokemons[0]);
            }
        }

        public Pokemon[] Pokemons1
        {
            get { return pokemons; }
            set { pokemons = value; }
        }


        private void Pokemons(string[] nomPokemonChoisir)
        {
            for (int i = 0; i < nomPokemonChoisir.Length; i++)
            {
                if (legendaire)
                {
                    pokemons[i] = new PokemonLegendary(nomPokemonChoisir[i], Atk1[i], Atk2[i], Atk3[i], Atk4[i]);
                }
                else
                {
                    pokemons[i] = new Pokemon(nomPokemonChoisir[i], Atk1[i], Atk2[i], Atk3[i], Atk4[i]);
                }
            }
        }


        public static Pokemon[] LoadPokemons()
        {
            // On crée un streamReader sur le fichier contenant le descriptif de nos Pokemons

            StreamReader reader = File.OpenText(@"D:\OneDrive - Ynov\Ingesup\2ieme_annee\C_Scharp\TP1_Pokemon\TP1_Pokemon\Model\pokemons.dat");
            

            {
                // Initialisation des variables nécessaires
                pokemon = new Pokemon[6];
                string[] items;
                int i = 0;
                string[] nomPokemonLegendaire = new string[6] {"Artiquodin", "New", "Sulfura", "Mewtow", "Elecktor", "Locklass"};
                // On lit la ligne d'entête de notre fichier (qui n'est donc pas une Pokemon)
                string line = reader.ReadLine();
                do
                {
                    line = reader.ReadLine();

                    if (!String.IsNullOrEmpty(line) && line.Length > 0)
                    {
                        items = line.Split(':');
                        

                        if (items.Length >= 8)
                        {
                            if (legendaire)
                            {
                                pokemon[i] = new Pokemon(nomPokemonLegendaire[i], Int32.Parse(items[5].Split('-')[0]),
                                    Int32.Parse(items[6].Split('-')[0]), 7, 8,
                                    items[1], Int32.Parse(items[2]), Int32.Parse(items[3]), Int32.Parse(items[3]));
                                i++;
                            }
                            else
                            {
                                pokemon[i] = new Pokemon(items[0], Int32.Parse(items[5].Split('-')[0]),
                                    Int32.Parse(items[6].Split('-')[0]), 7, 8,
                                    items[1], Int32.Parse(items[2]), Int32.Parse(items[3]), Int32.Parse(items[3]),
                                    items[5].Split('-')[1], items[6].Split('-')[1], items[7].Split('-')[1], items[8].Split('-')[1]);
                                i++;

                            }
                        }
                    }
                } while (line != null);
            }

            return pokemon;
        }
    }
}