using System;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// OBJECTIF PROCHAIN 
// GERER les pokemons légendaires
// on a hériter de la classe pokemon
// il faut générer les prochains. 


namespace TP1_Pokemon
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("---------------- BIENVENUE DANS POKEMON RETRO 2.0 ----------------");
            Console.WriteLine("--                                                              --");
            // StartGame startGame = new StartGame("");
            // startGame.musicGame(); 
            Application.Run(new Welcome());
        }
    }
}