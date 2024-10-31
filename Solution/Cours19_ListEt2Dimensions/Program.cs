/*
 * Auteur : Mael Perreault
 * Date : 31 octobre 2024
 * Cours 19 - List et tableaux à 2 dimensions
 */

namespace Cours19_ListEt2Dimensions
{
    internal class Program
    {
        private const bool ACTIVER_THEORIE = true;
        private const int MAX_JOUEURS = 4;
        private const int MAX_MANCHES = 10;
        private const int MAX_POINTAGE = 30;

        static void Main(string[] args)
        {
            if (ACTIVER_THEORIE)
            {
                // List qui permet un nombre d'éléments infini, pas de taille fixe
                List<int> entiers = new List<int>()
                {
                    10,
                    20,
                    30,
                };

                List<double> doubles = new List<double>()
                {
                    1.15,
                    2.57,
                    3.98,
                };

                List<string> chaines = new List<string>()
                {
                    "allo",
                    "bonjour",
                    "ciao",
                };

                // Fonctions propres au listes
                // Add - ajoute à la fin de la liste
                entiers.Add(40);
                doubles.Add(4.123);
                chaines.Add("pogo");

                // Insert - insere à l'index la valeur
                entiers.Insert(0, 50);
                doubles.Insert(0, 5.24);
                chaines.Insert(0, "poutine");

                // Erreur, on dépasse la taille du tableau
                //entiers.Insert(50, 999);

                entiers.Insert(entiers.Count, 60);
                doubles.Insert(doubles.Count, 6.88);
                chaines.Insert(chaines.Count, "frites");

                // Remove - supprime la premiere valeur equivalent a partir du debut [0]
                entiers.Remove(10);     // supprime de la liste
                doubles.Remove(1.15);   // supprime de la liste
                chaines.Remove("allo"); // supprime de la liste

                // Si élément n'est pas trouvé, ne crash pas, ne fait rien
                entiers.Remove(10);     // fait rien
                doubles.Remove(1.15);   // fait rien  
                chaines.Remove("allo"); // fait rien
                entiers.Remove(10);     // fait rien
                doubles.Remove(1.15);   // fait rien
                chaines.Remove("allo"); // fait rien

                // RemoveAt - supprimer l'index
                entiers.RemoveAt(2); // 3eme element
                doubles.RemoveAt(2);
                chaines.RemoveAt(2);

                // Erreur on dépasse le nombre d'éléments du tableau
                //entiers.RemoveAt(-1);
                //entiers.RemoveAt(entiers.Count);

                for (int i = 0; i < entiers.Count; i++)
                {
                    Console.WriteLine($"{chaines[i]} : {doubles[i]} - {entiers[i]}");
                }

                // Clear - supprimer tout les éléments
                entiers.Clear();
                doubles.Clear();
                chaines.Clear();

                // Itérer avec une boucle for de 0 à Count
                for (int i = 0; i < entiers.Count; i++)
                {
                    Console.WriteLine($"{chaines[i]} : {doubles[i]} - {entiers[i]}");
                }


                // Tableaux multidimensionnels (2D array)
                // Taille statique prédéfinie
                int[,] pointages = new int[MAX_JOUEURS, MAX_MANCHES]
                {
                    { 10, 20, 30, 0, 0, 0, 0, 0, 0, 0 },
                    { 2, 4, 6, 0, 0, 0, 0, 0, 0, 0 },
                    { 3, 7, 11, 0, 0, 0, 0, 0, 0, 0 },
                    { 9, 18, 27, 0, 0, 0, 0, 0, 0, 0 },
                };

                // Lire manche par manche, joueur par joueur
                for (int manche = 0; manche < MAX_MANCHES; manche++)
                {
                    // Afficher le titre de la manche
                    int numeroManche = manche + 1;
                    Console.WriteLine($"Manche {numeroManche}");

                    for (int joueur = 0; joueur < MAX_JOUEURS; joueur++)
                    {
                        // Lire le pointage valdie du joueur pour la manche
                        int pointage;
                        bool estPointageValide;
                        do
                        {
                            int numeroJoueur = joueur + 1;
                            Console.Write($"Joueur {numeroJoueur} : ");
                            string entree = Console.ReadLine();
                            estPointageValide = int.TryParse(entree, out pointage);

                        } while (!estPointageValide || pointage < 0 || pointage > MAX_POINTAGE);

                        // Écrire le pointage dans le tableau
                        pointages[joueur, manche] = pointage;
                    }
                }

                // Itérer 2 boucles 1) joueurs 2) manches
                for (int joueur = 0; joueur < MAX_JOUEURS; joueur++) // 4
                {
                    // Afficher le joueur
                    int numeroJoueur = joueur + 1;
                    Console.Write($"Joueur {numeroJoueur} : ");

                    // Afficher tous les pointages du joueur
                    for (int manche = 0; manche < MAX_MANCHES; manche++) // 10
                    {
                        int pointage = pointages[joueur, manche];
                        Console.Write($"{pointage,2} ");
                    }

                    // Sauter une ligne pour avoir chaque joueur sur une ligne différente
                    Console.WriteLine();
                }

            }
        }
    }
}
