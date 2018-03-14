using System;

namespace TP1_Pokemon
{
    public class Pokemon
    {
        protected String nomPokemon, type, nomAtk1, nomAtk2,nomAtk3,nomAtk4;
        protected int ptsVie;
        protected int atk1, atk2, atk3, atk4, maxLife, strengh, defense, hp;
        protected Random _random = new Random();
        private testData _testData = new testData();
        
       


        public Pokemon(string nomPokemon, int atk1, int atk2, int atk3, int atk4, string type = "plante", 
            int maxLife = 100, int strengh = 20, int defense = 20 , string nomAtk1 = "Atk1", string nomAtk2 = "Atk2",
            string nomAtk3 = "Atk3", string nomAtk4 = "Atk4")
        {
            this.nomPokemon = nomPokemon;
            this.ptsVie = maxLife;
            this.hp = maxLife;
            this.atk1 = atk1;
            this.atk2 = atk2;
            this.atk3 = atk3;
            this.atk4 = atk4;
            this.type = type;
            this.strengh = strengh;
            this.defense = defense;
            this.nomAtk1 = nomAtk1;
            this.nomAtk2 = nomAtk2;
            this.nomAtk3 = nomAtk3;
            this.nomAtk4 = nomAtk4;
        }

        public Pokemon()
        {
        }

        public string NomAtk1 
        {
            get { return nomAtk1; }
            set { nomAtk1 = value; }
        }
        public string NomAtk2
        {
            get { return nomAtk2; }
            set { nomAtk2 = value; }
        }
        public string NomAtk3
        {
            get { return nomAtk3; }
            set { nomAtk3 = value; }
        }
        public string NomAtk4
        {
            get { return nomAtk4; }
            set { nomAtk4 = value; }
        }

        public string NomPokemon
        {
            get { return nomPokemon; }
            set { nomPokemon = value; }
        }

        public int PtsVie
        {
            get { return ptsVie; }
            set { ptsVie = value; }
        }

        public int MaxVie
        {
            get { return hp; }
            set { hp = value; }
        }

        public int Atk1
        {
            get { return atk1; }
            set { atk1 = value; }
        }

        public int Atk2
        {
            get { return atk2; }
            set { atk2 = value; }
        }

        public int Atk3
        {
            get { return atk3; }
            set { atk3 = value; }
        }

        public int Atk4
        {
            get { return atk4; }
            set { atk4 = value; }
        }
        
        public String roar()
        {
            String partie1 = (this.NomPokemon).Substring(0, 5);
            return ("\"" + partie1 + " " + this.NomPokemon.ToUpper() + " !\"") ;
        }

        public int Attack (Pokemon pokemonVictim)
        {
//            String inputString = "";
//            int choixAttaque = 0;
//            
//            Console.WriteLine("Choix de l'attaque");
//            
//            
//            
//            choixAttaque = _testData.testChoixPokemonInput(choixAttaque, inputString, 4);
//            
//            
            
            int randomAttackChoice = _random.Next(1, 4);
            int atkChoisi = 1;
            
            switch (randomAttackChoice)
            {
                    case 1 : 
                        atkChoisi = Atk1;
                        break;
                    case 2 : 
                        atkChoisi = Atk2;
                        break;
                    case 3 : 
                        atkChoisi = Atk3;
                        break;
                    case 4 :
                        atkChoisi = Atk4;
                        break;
                    default: atkChoisi = 1;
                        break;      
            }
            Console.WriteLine("    => " + this.NomPokemon.ToUpper() + " attaque et inflige " + atkChoisi + " a " + pokemonVictim.NomPokemon);
            pokemonVictim.ptsVie = pokemonVictim.PtsVie - atkChoisi;
            return (pokemonVictim.PtsVie - atkChoisi);
        }
    }
}