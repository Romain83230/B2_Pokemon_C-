using System;
using System.Configuration;
using System.Media;
using System.Windows.Forms;

namespace TP1_Pokemon
{
    public class StartGame
    {
        private Pokemon[] pokemons;
        Combat _combat = new Combat();
        private testData _testData = new testData();
        protected Random _random = new Random();


        public StartGame()
        {
        }

        public int randomNumer(int min, int max)
        {
            int number = _random.Next(min, max);
            return number;
        }

        /*public void musicGame()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "music.wav";
            player.Play();
        }*/

        public StartGame(String nul)
        {
            //musicGame();
            Menu();
        }

        private void InitializePokemon()
        {
            Menu();
        }

        public void Menu()
        {
            String choixMenuJoueurString = "1";
            int choixMenuJoueur = 1;
            Console.WriteLine("--                                                              --");
            Console.WriteLine("--                             MENU                             --");
            Console.WriteLine("--                           1. Jouer                           --");
            Console.WriteLine("--                           2. Jouer (Legendaire)              --");
            Console.WriteLine("--                           3. Quitter                         --");
            choixMenu(choixMenuJoueur, choixMenuJoueurString);
        }


        public static Pokemon[] returnGeneratedPokemon()
        {
            return GenerationPokemon.LoadPokemons();
        }


        private void ExitGame()
        {
            Console.WriteLine("--                                                              --");
            Console.WriteLine("--             Le choix n'existe pas, nous quittons             --");
            Environment.Exit(0);
        }


        public static void rejouer()
        {
            StartGame startGame = new StartGame();
            startGame.InitializePokemon();
        }

        public void ChoisePokemon(int choixPokemonJoueur = 0)
        {
            String choixPokemonJoueurString = "", choiadversaireJoueurString = "";
            int choixAdversairePokemon = 1;
            int maxNumber = 10; // réduisons les chances de tomber sur un pokemon shinny :) 
            int shinnyJoueur = randomNumer(0, maxNumber),
                shinnyAdversaire = randomNumer(0, maxNumber),
                baseShinny = randomNumer(0, maxNumber);

            pokemons = returnGeneratedPokemon();
            Pokemon[] choixPokemon = new Pokemon[2];
            choixPokemonJoueur = ChoixPokemonJoueur(choixPokemonJoueur);
            choixAdversairePokemon = ChoixAdversairePokemon(choixPokemonJoueur, pokemons.Length);
            choixPokemon[0] = pokemons[(choixPokemonJoueur)];
            choixPokemon[1] = pokemons[(choixAdversairePokemon)];

            isShinny(shinnyJoueur, baseShinny, choixPokemon, shinnyAdversaire);

            // START COMBAT
            Combat.initGame(pokemons);
            _combat.tour(choixPokemon);
        }

        private static void isShinny(int shinnyJoueur, int baseShinny, Pokemon[] choixPokemon, int shinnyAdversaire)
        {
            if (shinnyJoueur == baseShinny)
            {
                Console.WriteLine("OOOOH My God !! " + choixPokemon[0].NomPokemon + " est un pokemon Shinny !!");
                choixPokemon[0].PtsVie += 50;
                choixPokemon[0].Atk1 += 10;
                choixPokemon[0].Atk2 += 10;
                choixPokemon[0].Atk3 += 10;
                choixPokemon[0].Atk4 += 10;
                choixPokemon[0].NomPokemon += "-Le-Lumineux";
            }

            if (shinnyAdversaire == baseShinny)
            {
                Console.WriteLine("OOOOH My God !! " + choixPokemon[1].NomPokemon + " est un pokemon Shinny !!");
                choixPokemon[1].PtsVie += 50;
                choixPokemon[1].Atk1 += 10;
                choixPokemon[1].Atk2 += 10;
                choixPokemon[1].Atk3 += 10;
                choixPokemon[1].Atk4 += 10;
                choixPokemon[1].NomPokemon += "-Le-Lumineux";
            }
        }

        private void choixMenu(int choixMenuJoueur, string choixMenuJoueurString)
        {
            choixMenuJoueur = _testData.testChoixPokemonInput(choixMenuJoueur, choixMenuJoueurString, 3);

            switch (choixMenuJoueur)
            {
                case 1:
                    ChoisePokemon();
                    break;
                case 2:
                    GenerationPokemon.legendaire = true;
                    ChoisePokemon();
                    break;
                case 3:
                    Console.WriteLine("On quitte le jeu.");
                    Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        public int ChoixAdversairePokemon(int choixPokemonJoueur, int pokeLength)
        {
            int choixAdversairePokemon;
            Console.WriteLine("--                L\'adversaire jouera avec...             --");
            Console.WriteLine("\n");
            do
            {
                int choix = randomNumer(0, pokeLength);
                choixAdversairePokemon = choix;
            } while (choixAdversairePokemon == choixPokemonJoueur);

            
            Console.WriteLine("\n");
            return choixAdversairePokemon;
        }

        private int ChoixPokemonJoueur(int choixPokemonJoueur)
        {
            string choixPokemonJoueurString = choixPokemonJoueur.ToString();
            Console.WriteLine("--                                                              --");
            Console.WriteLine("--                Quelle pokemon choississez-vous ?             --");
            for (int i = 0; i < pokemons.Length; i++)
            {
                Console.WriteLine(i + ". " + pokemons[i].NomPokemon);
            }


            choixPokemonJoueur = _testData.testChoixPokemonInput(choixPokemonJoueur, choixPokemonJoueurString, 6);
            MessageBox.Show("le choix " + choixPokemonJoueur);

            return choixPokemonJoueur;
        }
    }
}