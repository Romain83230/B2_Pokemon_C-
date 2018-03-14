using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP1_Pokemon.View;
using Microsoft.VisualBasic;

namespace TP1_Pokemon
{
    public partial class PokemonVersionRouge : Form
    {
        List<String> pokeList;
        int position = 0;
        int choixpokeAdversaire = 1;
        private Pokemon[] pokemons;
        Pokemon[] choixPokemon = new Pokemon[2];
        StartGame StartGame = new StartGame();
        Combat _combat = new Combat();

        public PokemonVersionRouge()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            pb_choixpokeadversaire.Hide();
            pb_votrechoixpoke.Hide();
            Description_poke_adversaire.Hide();
            Description_poke_joueur.Hide();
            b_combat.Hide();
            label_votrepoke.Hide();
            label_adversairePoke.Hide();
            label_VS.Hide();
            pokemons = GenerationPokemon.LoadPokemons();
            pokeList = new List<String>();
            int i = 0;
            String path = @"D:\OneDrive - Ynov\Ingesup\2ieme_annee\C_Scharp\TP1_Pokemon\TP1_Pokemon\Model\pokemon";
            try
            {
                //foreach (string fileName in Directory.GetFiles(@"C:\Users\Romain\Documents\OneDrive - Ynov\Ingesup\2ieme_annee\C_Scharp\TP1_Pokemon\TP1_Pokemon\Model\pokemon\"))
                foreach (string fileName in Directory.GetFiles(path))
                    {
                    pokeList.Add(fileName);
                    Console.WriteLine(pokeList[i]);
                    i++;
                }
            } catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Il semblerait que le chemin pour accéder aux images ne convient pas. Veuillez entrer le votre :  ");
                problemAccessDossierPokemon chemin = new problemAccessDossierPokemon();
                this.Hide();
                chemin.Show();
            }
            

            try
            {
                Image image = Image.FromFile(pokeList[position]);
                pokeBox.SizeMode = PictureBoxSizeMode.Zoom;
                this.pokeBox.Image = image;
                fillPokeStat(position, label_pokemon_stats);
            }
            catch (ArgumentOutOfRangeException)
            {
                position = 0;
            }

            
        }

        private void fillPokeStat(int position, Label label)
        {
            label.Text = "Nom du pokemon : " + pokemons[position].NomPokemon.ToString() + "\n" +
                    "pts :     " + pokemons[position].PtsVie.ToString() + "\n" +
                    "Atk 1 : " + pokemons[position].Atk1.ToString() + "\n" +
                    "Atk 2 : " + pokemons[position].Atk2.ToString() + "\n" +
                    "Atk 3 : " + pokemons[position].Atk3.ToString() + "\n" +
                    "Atk 4 : " + pokemons[position].Atk4.ToString() + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            position = position + 1;
            try
            {
                Image image = Image.FromFile(pokeList[position]);
                pokeBox.SizeMode = PictureBoxSizeMode.Zoom;
                this.pokeBox.Image = image;
                fillPokeStat(position, label_pokemon_stats);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Vous avez fait le tour des pokemons disponibles");
                position = 0;
            }
        }

        private void pokeBox_Click(object sender, EventArgs e)
        {
            int maxNumber = 10;
            int shinnyJoueur = StartGame.randomNumer(0, maxNumber),
                shinnyAdversaire = StartGame.randomNumer(0, maxNumber),
                baseShinny = StartGame.randomNumer(0, maxNumber);
            
            choixpokeAdversaire = StartGame.ChoixAdversairePokemon(position, pokemons.Length);
            choixPokemon[1] = pokemons[choixpokeAdversaire];
            choixPokemon[0] = pokemons[position];
            b_previous.Hide();
            b_next.Hide();
            pokeBox.Hide();
            Choisir.Hide();

            Image imageJoueur = Image.FromFile(pokeList[position]);
            pb_votrechoixpoke.SizeMode = PictureBoxSizeMode.Zoom;
            this.pb_votrechoixpoke.Image = imageJoueur;

            Image imageAdversaire = Image.FromFile(pokeList[choixpokeAdversaire]);
            pb_choixpokeadversaire.SizeMode = PictureBoxSizeMode.Zoom;
            this.pb_choixpokeadversaire.Image = imageAdversaire;

            fillPokeStat(choixpokeAdversaire, Description_poke_adversaire);
            fillPokeStat(position, Description_poke_joueur);

            pb_choixpokeadversaire.Show();
            pb_votrechoixpoke.Show();
            Description_poke_adversaire.Show();
            Description_poke_joueur.Show();
            b_combat.Show();
            label_votrepoke.Show();
            label_adversairePoke.Show();
            label_VS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            position = position - 1;
            
            Console.WriteLine(pokeList.Count - position);
            try
            {
                Image image = Image.FromFile(pokeList[position]);
                pokeBox.SizeMode = PictureBoxSizeMode.Zoom;
                this.pokeBox.Image = image;
                fillPokeStat(position, label_pokemon_stats);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Vous êtes déjà au début de la liste");
                position = 0;
            }
        }

        private void Tb_pokemonStats_TextChanged(object sender, EventArgs e)
        {

        }

        private void PokemonVersionRouge_Load(object sender, EventArgs e)
        {

        }

        private void Description_poke_adversaire_Click(object sender, EventArgs e)
        {

        }

        private void pb_choixpokeadversaire_Click(object sender, EventArgs e)
        {

        }

        private void label_pokemon_stats_Click(object sender, EventArgs e)
        {

        }

        private void b_combat_Click(object sender, EventArgs e)
        {
            CombatPokemon combat = new CombatPokemon(choixPokemon, pokeList[position], pokeList[choixpokeAdversaire]);
            this.Hide();
            combat.ShowDialog();
            // START COMBAT
            Combat.initGame(pokemons);
            _combat.tour(choixPokemon);
        }
    }
}
