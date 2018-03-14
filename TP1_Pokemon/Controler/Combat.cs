using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using TP1_Pokemon.View;

namespace TP1_Pokemon
{
    public class Combat
    {
        private int nombretour = 0;
        private int currentTurn = 0;
        protected Random _random = new Random();
        private static List<Pokemon> oldJoueurPokemon = new List<Pokemon>();
        private static List<Pokemon> oldAdversaireJoueur = new List<Pokemon>();
        CombatPokemon combatPokemon;


        public static void initGame(Pokemon[] pokemons)
        {
            pokemons = StartGame.returnGeneratedPokemon();
            for (int i = 0; i < pokemons.Length; i++)
            {
                oldJoueurPokemon.Add(pokemons[i]);
                oldAdversaireJoueur.Add(pokemons[i]);
            }
        }

        public Combat()
        {
        }

        private int randomNumer(int min, int max)
        {
            int number = _random.Next(min, max);
            return number;
        }

        /**
         * Classe principale gérant le tour par tour
         */
        public void tour(Pokemon[] duelPokemons)
        {
            int vieJoueur;
            var vieEnnemie = initCombat(duelPokemons, out vieJoueur);

            /*while (duelPokemons[0].PtsVie >= 0 | duelPokemons[1].PtsVie >= 0)
            {
                if (duelPokemons[currentTurn] == duelPokemons[0])
                {
                    logiqueJoueur(duelPokemons, vieJoueur);
                }
                else
                {
                    logiqueAdversaire(duelPokemons, vieEnnemie);
                }
                if (duelPokemons[currentTurn].PtsVie <= 0 | duelPokemons[currentTurn ^ 1].PtsVie <= 0)
                {
                    ChargementPokemonLegendaire(duelPokemons);
                    break;
                }

                //Console.ReadLine();
                currentTurn = currentTurn ^ 1;
            }
            */
            Console.WriteLine("Le combat est terminé");
        }

        /**
         * Génération du premier tour avec les phrases qui vont bien
         */
        private static int initCombat(Pokemon[] duelPokemons, out int vieJoueur)
        {
            int vieEnnemie;
            vieEnnemie = duelPokemons[1].PtsVie;
            vieJoueur = duelPokemons[0].PtsVie;
            Console.WriteLine("Le combat va démarrer !".ToUpper());
            Console.WriteLine("Vous combattez avec " + duelPokemons[0].NomPokemon.ToUpper() + ", il a " +
                              duelPokemons[0].PtsVie + " pts de vie");
            Console.WriteLine("Votre adversaire a " + duelPokemons[1].NomPokemon.ToUpper() + ", il a " +
                              duelPokemons[1].PtsVie + " pts de vie");
            Console.WriteLine();
            return vieEnnemie;
        }

        /**
         * IA adversaire
         */
        private void logiqueAdversaire(Pokemon[] duelPokemons, int vieEnnemie)
        {
            Console.WriteLine("\n");
            int choix = randomNumer(0, 4);
            if (duelPokemons[1].PtsVie <= vieEnnemie * 0.5)
            {
                if (choix == 1)
                {
                    pokeRoar(duelPokemons);
                }

                Attaque(duelPokemons);
            }
            else if (duelPokemons[1].PtsVie <= vieEnnemie * 0.2)
            {
                int tentativeFuite = randomNumer(0, 10);
                if (tentativeFuite == choix)
                {
                    fuite(duelPokemons);
                }
            }
            else
            {
                switch (choix)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        Attaque(duelPokemons);
                        break;
                    case 4:
                        Soin(duelPokemons[currentTurn], vieEnnemie);
                        break;
                }
            }
        }

        /**
         * Interaction joueur/PC
         */
        private void logiqueJoueur(Pokemon[] duelPokemons, int vieJoueur, int menu = 1)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Que souhaitez-vous faire ? ");
            int choixMenuJoueur = 1;
            Console.WriteLine("--                                                              --");
            Console.WriteLine("--                           1. Attaquer                        --");
            Console.WriteLine("--                           2. Rugir                           --");
            Console.WriteLine("--                           3. Sac                             --");
            Console.WriteLine("--                           4. Changer pokemon                 --");
            Console.WriteLine("--                           5. Lister Pokemon Ennemie          --");
            Console.WriteLine("--                           6. Fuite                           --");
            choixMenuJoueur = menu;


            switch (choixMenuJoueur)
            {
                case 1:
                    Attaque(duelPokemons);
                    break;
                case 2:
                    pokeRoar(duelPokemons);
                    Attaque(duelPokemons);
                    break;
                case 3:
                    loadSac(duelPokemons, vieJoueur);
                    break;
                case 4:
                    switchPokemon(duelPokemons);
                    break;
                case 5:
                    for (int i = 0; i < oldAdversaireJoueur.Count; i++)
                    {
                        Console.WriteLine(oldAdversaireJoueur[i].NomPokemon + "  -- "
                                                                            + oldAdversaireJoueur[i].PtsVie +
                                                                            " pts de vie / "
                                                                            + oldAdversaireJoueur[i].Atk1 + " ATK1 / "
                                                                            + oldAdversaireJoueur[i].Atk2 + " ATK2 / "
                                                                            + oldAdversaireJoueur[i].Atk3 + " ATK3 / "
                                                                            + oldAdversaireJoueur[i].Atk4 + " ATK4");
                    }

                    logiqueJoueur(duelPokemons, vieJoueur);
                    break;
                case 6:
                    fuite(duelPokemons);
                    break;
                default:
                    Console.WriteLine("Mauvais choix...");
                    Console.WriteLine("On perd l'attaque...");
                    break;
            }
        }

        /**
         * Changement de pokemon, stockage du précédent dans le tableau oldJoueurPokemon
         */
        private void switchPokemon(Pokemon[] duelPokemons, int choixpoke = 1)
        {
            Pokemon[] pokemons;
            pokemons = StartGame.returnGeneratedPokemon();
            int choixPokemonJoueur = 0;
            do
            {
                Console.WriteLine(
                    "Quelle pokemon choississez-vous ? (Les pokemons en cours de combat ne s'affichent pas)".ToUpper());
                for (int i = 0; i < pokemons.Length; i++)
                {
                    if (pokemons[i].NomPokemon == duelPokemons[currentTurn].NomPokemon ||
                        pokemons[i].NomPokemon == duelPokemons[currentTurn ^ 1].NomPokemon)
                    {
                        continue;
                    }
                    
                    Console.WriteLine(i + ". " + pokemons[i].NomPokemon.ToUpper() + " -- "
                                      + pokemons[i].PtsVie + " pts de vie / "
                                      + pokemons[i].Atk1 + " attaque 1 / "
                                      + pokemons[i].Atk2 + " attaque 2 / "
                                      + pokemons[i].Atk3 + " attaque 3 / "
                                      + pokemons[i].Atk4 + " attaque 4 ");
                }

                choixPokemonJoueur = choixpoke;
            } while (pokemons[choixPokemonJoueur].NomPokemon == duelPokemons[currentTurn].NomPokemon ||
                     pokemons[choixPokemonJoueur].NomPokemon == duelPokemons[currentTurn ^ 1].NomPokemon);

            var itemToRemove =
                oldJoueurPokemon.SingleOrDefault(r => r.NomPokemon == duelPokemons[currentTurn].NomPokemon);
            if (itemToRemove != null)
            {
                oldJoueurPokemon.Remove(itemToRemove);
                oldJoueurPokemon.Add(duelPokemons[currentTurn]);
            }

            duelPokemons[0] = pokemons[choixPokemonJoueur];
            tour(duelPokemons);
        }


        /**
         * Fuire un combat
         */
        private void fuite(Pokemon[] duelPokemons)
        {
            Console.WriteLine("Pfff, " + duelPokemons[currentTurn] + " prend la fuite...");
            if (GenerationPokemon.legendaire)
            {
                Environment.Exit(0);
            }
            else
            {
                ChargementPokemonLegendaire(duelPokemons);
            }
        }

        /**
         * lancement du rigissement !
         */
        private void pokeRoar(Pokemon[] duelPokemons)
        {
            Console.WriteLine("Le pokemon rugit !! " + duelPokemons[currentTurn].roar());
        }

        /**
         * Accès au sac
         */
        private void loadSac(Pokemon[] duelPokemons, int vieJoueur, int choixObjetInput = 1)
        {
            Potions potions = new Potions();
            int choixObject = 1;
            Console.WriteLine("--                           1. Potion soin                     --");
            Console.WriteLine("--                           2. retour                          --");
            choixObject = choixObjetInput;

            switch (choixObject)
            {
                case 1:
                    Soin(duelPokemons[currentTurn], vieJoueur);
                    break;
                case 2:
                    Attaque(duelPokemons);
                    break;

                default:
                    Console.WriteLine("Mauvais choix. On retourne au combat");
                    Attaque(duelPokemons);
                    break;
            }
        }

        /**
         * Accés au potion de soin
         */
        private static void Soin(Pokemon duelPokemons, int vie)
        {
            Console.WriteLine("$$$$$$$ " + duelPokemons.NomPokemon + " decide de se soigner ! $$$$$$$");
            int santeToRestaure = vie - duelPokemons.PtsVie;
            Console.WriteLine("$$$$$$$ " + duelPokemons.NomPokemon + " retrouve " + santeToRestaure +
                              " points de vie. Il est maintenant à " + vie + " pts de vie. $$$$$$$");
            duelPokemons.PtsVie = duelPokemons.PtsVie + santeToRestaure;
        }

        /**
         * Chargement des pokemons légendaires
         */
        private void ChargementPokemonLegendaire(Pokemon[] duelPokemons)
        {
            Console.WriteLine(duelPokemons[currentTurn].NomPokemon.ToUpper() + " a gagné le combat !!");
            Console.WriteLine("\n\n");
            StartGame.rejouer();
        }

        /**
         * 
         */
        public void Attaque(Pokemon[] duelPokemons)
        {
            combatPokemon = new CombatPokemon();

            combatPokemon.setCombatDescription(" #" + duelPokemons[currentTurn].NomPokemon.ToUpper() + "# attaque #" +
                              duelPokemons[currentTurn ^ 1].NomPokemon.ToUpper() + "# ");

            duelPokemons[currentTurn].Attack(duelPokemons[currentTurn ^ 1]);

            if (duelPokemons[currentTurn].PtsVie <= 0)
            {
                duelPokemons[currentTurn].PtsVie = 0;
            }
            else if (duelPokemons[currentTurn ^ 1].PtsVie <= 0)
            {
                duelPokemons[currentTurn ^ 1].PtsVie = 0;
            }

            combatPokemon.setCombatDescription(duelPokemons[currentTurn].NomPokemon.ToUpper() + " a " +
                              duelPokemons[currentTurn].PtsVie +
                              " pts de vie et " + duelPokemons[currentTurn ^ 1].NomPokemon.ToUpper() + " a " +
                              duelPokemons[currentTurn ^ 1].PtsVie + " pts de vie.");
            if (duelPokemons[1].PtsVie == 0)
            {
                switchPokemonAdversaire(duelPokemons);
            }

            if (duelPokemons[0].PtsVie == 0)
            {
                switchPokemon(duelPokemons);
            }
        }

        private void switchPokemonAdversaire(Pokemon[] duelPokemons)
        {
            Pokemon[] pokemons;
            pokemons = StartGame.returnGeneratedPokemon();
            int choixnewPokemon = 0;
            do
            {
                choixnewPokemon = randomNumer(0, 6);
                Console.WriteLine("coucou");
            } while (duelPokemons[1].NomPokemon == pokemons[choixnewPokemon].NomPokemon &&
                     pokemons[choixnewPokemon].PtsVie > 0);

            var itemToRemove =
                oldAdversaireJoueur.SingleOrDefault(r => r.NomPokemon == duelPokemons[1].NomPokemon);
            if (itemToRemove != null)
            {
                oldAdversaireJoueur.Remove(itemToRemove);
                oldAdversaireJoueur.Add(duelPokemons[1]);
            }

            duelPokemons[1] = pokemons[choixnewPokemon];
            Console.WriteLine("__________L\'adversaire change de pokemon !! il prend " +
                              duelPokemons[1].NomPokemon.ToUpper() + "__________");
            tour(duelPokemons);
        }
    }
}