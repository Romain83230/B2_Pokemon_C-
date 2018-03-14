using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP1_Pokemon.View
{
    public partial class CombatPokemon : Form
    {
        private Pokemon[] pokemons, pokemonsStatBase;
        private String pokeJoueur, pokeAdversaire;
        private int currentTurn = 0;
        Combat combatConsole = new Combat();
        

        public CombatPokemon()
        {

        }

        public CombatPokemon(Pokemon[] pokemon, String pokejoueur, String pokeAdv)
        {
            this.pokemons = pokemon;
            this.pokemonsStatBase = pokemons;
            this.pokeJoueur = pokejoueur;
            this.pokeAdversaire = pokeAdv;
            InitializeComponent();
            init();
        }

        private void init()
        {
            b_Atk1.Hide();
            b_Atk2.Hide();
            b_Atk3.Hide();
            b_Atk4.Hide();
            b_retour.Hide();

            Image image = Image.FromFile(pokeJoueur);
            pb_pokeJoueur.SizeMode = PictureBoxSizeMode.Zoom;
            this.pb_pokeJoueur.Image = image;

            Image imageAdv = Image.FromFile(pokeAdversaire);
            pb_pokeAdversaire.SizeMode = PictureBoxSizeMode.Zoom;
            this.pb_pokeAdversaire.Image = imageAdv;

            label_nomPokeAdv.Text = pokemons[1].NomPokemon;
            label_nompokeJoueur.Text = pokemons[0].NomPokemon;

            label_viepokeadv.Text = pokemons[1].PtsVie.ToString() + "/" + pokemons[1].PtsVie.ToString();
            label_viepokejoueur.Text = pokemons[0].PtsVie.ToString() + "/" + pokemons[0].PtsVie.ToString();


        }

        

        private void label_descriptionCombat_Click(object sender, EventArgs e)
        {

        }
        // Définition stat du jeu
        // ============================================================================
        public void setCombatDescription(String describ)
        {
            label_descriptionCombat.Text += describ + "\n";
        }

        public void displaypokeJoueurVie(int vie)
        {
            label_viepokejoueur.Text = vie + "/" + pokemonsStatBase[0].MaxVie.ToString();
        }

        public void displaypokeAdvVie(int vie)
        {
            label_viepokeadv.Text = vie + "/" + pokemonsStatBase[1].MaxVie.ToString();
        }

        public void displaypokeJoueurVieProgressBar(int vie)
        {
            pb_viePoke.Maximum = pokemons[0].MaxVie;
            pb_viePoke.Step = 1;
            pb_viePoke.Value = vie;
        }

        public void displaypokeAdvVieProgressBar(int vie)
        {
            pb_vieAdv.Maximum = pokemons[1].MaxVie;
            pb_vieAdv.Step = 1;
            pb_vieAdv.Value = vie;
        }
        // ============================================================================

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void b_accesSac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonction bientôt disponible");
        }

        private void b_attaquer_Click(object sender, EventArgs e)
        {
            attaquerEnnemie();
        }

        public void setPokeJoueurNomLabel (String nom)
        {
            label_nomPokeAdv.Text = nom;
        }

        public void attaquerEnnemie()
        {
            b_accesSac.Hide();
            b_attaquer.Hide();

            b_Atk1.Text = "0- "+pokemons[0].NomAtk1;
            b_Atk2.Text = "1- " + pokemons[0].NomAtk2;
            b_Atk3.Text = "2- " + pokemons[0].NomAtk3;
            b_Atk4.Text = "3- " + pokemons[0].NomAtk4;

            b_Atk1.Show();
            b_Atk2.Show();
            b_Atk3.Show();
            b_Atk4.Show();
            b_retour.Show();
        }

        private void b_retour_Click(object sender, EventArgs e)
        {
            menuCombat();
        }

        private void b_Atk1_Click(object sender, EventArgs e)
        {
            tourpartour(b_Atk1.Text.Split('-')[0]);
        }

        public void menuCombat()
        {
            b_Atk1.Hide();
            b_Atk2.Hide();
            b_Atk3.Hide();
            b_Atk4.Hide();
            b_retour.Hide();
            b_accesSac.Show();
            b_attaquer.Show();
        }

        private void b_Atk2_Click(object sender, EventArgs e)
        {
            tourpartour(b_Atk2.Text.Split('-')[0]);
        }

        private void b_Atk3_Click(object sender, EventArgs e)
        {
            tourpartour(b_Atk3.Text.Split('-')[0]);
        }

        private void b_Atk4_Click(object sender, EventArgs e)
        {
            tourpartour(b_Atk4.Text.Split('-')[0]);
        }

        private void label_descriptionCombat_TextChanged(object sender, EventArgs e)
        {

        }

        

        public void tourpartour (string atkVal)
        {

            Attaque();
            /*int vieJoueur;
            var vieEnnemie = initCombat(duelPokemons, out vieJoueur);

            while (duelPokemons[0].PtsVie >= 0 | duelPokemons[1].PtsVie >= 0)
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
                
            }
            
            Console.WriteLine("Le combat est terminé");*/
            currentTurn = currentTurn ^ 1;
        }


        private void Attaque()
        {
            if (pokemons[currentTurn].PtsVie > 0 && pokemons[currentTurn^1].PtsVie > 0)
            {
                pokemons[currentTurn].Attack(pokemons[currentTurn ^ 1]);
                setCombatDescription(" #" + pokemons[currentTurn].NomPokemon.ToUpper() + "# attaque #" +
                                  pokemons[currentTurn ^ 1].NomPokemon.ToUpper() + "# ");
                if (pokemons[currentTurn].PtsVie <= 0)
                {
                    pokemons[currentTurn].PtsVie = 0;
                    setCombatDescription("Le pokemon " + pokemons[currentTurn].NomPokemon + " a perdu...");
                }
                else if (pokemons[currentTurn ^ 1].PtsVie <= 0)
                {
                    pokemons[currentTurn ^ 1].PtsVie = 0;
                    setCombatDescription("Le pokemon " + pokemons[currentTurn ^ 1].NomPokemon + " a perdu...");
                }
                else
                {

                    setCombatDescription(pokemons[currentTurn].NomPokemon.ToUpper() + " a " +
                                  pokemons[currentTurn].PtsVie +
                                  " pts de vie et " + pokemons[currentTurn ^ 1].NomPokemon.ToUpper() + " a " +
                                  pokemons[currentTurn ^ 1].PtsVie + " pts de vie.");
                }
                if (currentTurn == 0)
                {
                    displaypokeAdvVie(pokemons[1].PtsVie);
                    displaypokeAdvVieProgressBar(pokemons[1].PtsVie);
                }
                else
                {
                    displaypokeJoueurVie(pokemons[0].PtsVie);
                    displaypokeJoueurVieProgressBar(pokemons[0].PtsVie);
                }
            } else
            {
                setCombatDescription("Le combat est terminé !");
            }
            


            /*if (duelPokemons[1].PtsVie == 0)
            {
                switchPokemonAdversaire(duelPokemons);
            }

            if (duelPokemons[0].PtsVie == 0)
            {
                switchPokemon(duelPokemons);
            }*/
        }


    }
}
