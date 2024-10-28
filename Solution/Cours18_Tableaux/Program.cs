/*
 * Auteur : Mael Perreault
 * Date : 28 octobre 2024
 * Cours 18 - Tableaux
 */

namespace Cours18_Tableaux
{
    internal class Program
    {
        private const bool ACTIVER_THEORIE = true;

        // Permet de modifier rapidement le nombre d'élément du tableau et les boucles
        private const int MAX_JOUEURS = 5;

        static void Main(string[] args)
        {
            if (ACTIVER_THEORIE)
            {
                // Ancienne facon, 1 variable par donnée
                // Ne permet pas facilement d'avoir 100, 1000, etc. éléments
                string joueur1 = "Al";
                string joueur2 = "Bob";
                string joueur3 = "Carl";
                string joueur4 = "Dan";

                int pointsJoueur1 = 0;
                int pointsJoueur2 = 0;
                int pointsJoueur3 = 0;
                int pointsJoueur4 = 0;

                // Il faut se répéter pour afficher avec plusieurs variables
                Console.WriteLine($"{joueur1} : {pointsJoueur1}");
                Console.WriteLine($"{joueur2} : {pointsJoueur2}");
                Console.WriteLine($"{joueur3} : {pointsJoueur3}");
                Console.WriteLine($"{joueur4} : {pointsJoueur4}");

                // Tableaux
                // Permet d'avoir une seule variable qui contient plusieurs valeurs

                // Définir et initialiser le tableau demande de définir toutes les valeurs en même temps
                string[] joueurs = new string[MAX_JOUEURS]
                {
                    "Al",   // [0]
                    "Bob",  // [1]
                    "Carl", // [2]
                    "Dan",  // [3]
                    "Earl", // [4]
                };

                // Définir un tableau sans l'initialiser mets la valeurs à la valeur de base (ex. 0, "", etc.)
                int[] points = new int[MAX_JOUEURS]; // Tous les éléments sont initialisés à 0

                // Modifier les valeurs du tableau avec une à une avec les crochets [index] à partir de [0]
                points[2] = 10; // Carl
                points[4] += 5; // Earl

                // Accèder à l'index -1 ou taille du tableau crash le programme (OutOfRange exeception)
                //joueurs[-1] = "Erreur";
                //joueurs[4] = "Erreur";

                //joueurs[0] = "Al";
                //joueurs[1] = "Bob";
                //joueurs[2] = "Carl";
                //joueurs[3] = "Dan";

                // Boucler sur le tableau de 0 à la taile - 1
                for (int i = 0; i < MAX_JOUEURS; i++) // < 4
                {
                    // Utiliser les éléments du tableau dans la boucle avec [i]
                    Console.WriteLine($"{joueurs[i]} : {points[i]}"); // 0, 1, 2, 3
                }
            }

            // Exercices
        }
    }
}
