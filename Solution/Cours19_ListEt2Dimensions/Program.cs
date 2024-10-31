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
            }
        }
    }
}
