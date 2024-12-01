using System;

namespace MonApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Affiche un message d'accueil
            Console.WriteLine("Bienvenue dans mon application console !");

            // Demande le nom de l'utilisateur
            Console.Write("Entrez votre nom : ");
            string nom = Console.ReadLine();

            // Demande l'âge de l'utilisateur
            Console.Write("Entrez votre âge : ");
            int age = int.Parse(Console.ReadLine());

            // Affiche un message personnalisé
            Console.WriteLine($"Bonjour {nom}, vous avez {age} ans.");

            // Attendre que l'utilisateur appuie sur une touche pour fermer
            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
