using System;

namespace TP1_Pokemon
{
    public class testData
    {
        public testData()
        {
            
        }

        public int testChoixPokemonInput(int choixInt, string choixString, int longueur)
        {
            do
            {
                Console.Write("Votre choix : ");
                try
                {
                    choixInt = Int32.Parse(choixString);
                }
                catch (FormatException e)
                {
                    testChoixPokemonInput(choixInt, choixString, longueur);
                }
                catch (IndexOutOfRangeException f)
                {
                    testChoixPokemonInput(choixInt, choixString, longueur);
                }
            } while (choixInt > longueur || choixInt < 0);

            return choixInt;
        }
    }
}

