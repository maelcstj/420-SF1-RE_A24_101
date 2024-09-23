/*
 * Auteur : Mael Perreault
 * Date : 9 septembre 2024
 * Cours 06 - Constantes et Modulo
 */

using System.Globalization;

namespace Cours06_ConstantesModulo
{
    internal class Program
    {
        // Constantes (UPPER_SNAKE_CASE)
        const int NOMBRE_A_AJOUTER = 99; // 10 => 99
        const string MEMBRE_OR = "gold"; // "or" => "gold"
        const int BONUS_ENTIER = 20;
        const bool THEORIE_ACTIF = false;

        static void Main(string[] args)
        {
            // Configurer culture pour tout le programme
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            if (THEORIE_ACTIF)
            {
                //NOMBRE_A_AJOUTER = 10; // erreur, ne peut pas modifier une constante

                Console.Write("Entrer un nombre entier : ");
                string entreeEntier = Console.ReadLine();
                // int entier = int.Parse(entreeEntier);

                // int entier; // out permet ecrire ici
                bool estEntierValide = int.TryParse(entreeEntier, out int entier);
                if (estEntierValide)
                {
                    // Opérations somme
                    // +=, -=, *=, /=
                    // nombre = nombre + 20;
                    // nombre += 20;
                    entier += BONUS_ENTIER;

                    Console.WriteLine($"Le nombre + {NOMBRE_A_AJOUTER} : {entier + NOMBRE_A_AJOUTER}");
                }
                else
                {
                    Console.WriteLine("Le nombre est invalide");
                }

                Console.Write("Entrer un nombre a virgule : ");
                string entreeVirgule = Console.ReadLine();
                // double virgule = double.Parse(entreeVirgule, CultureInfo.InvariantCulture);

                // double virgule; // out permet ecrire ici
                // bool estVirguleValide = double.TryParse(entreeVirgule, CultureInfo.InvariantCulture, out double virgule);

                bool estVirguleValide = double.TryParse(entreeVirgule, out double virgule);
                if (estVirguleValide)
                {
                    Console.WriteLine($"Le nombre + {NOMBRE_A_AJOUTER} : {virgule + NOMBRE_A_AJOUTER:0.000}");
                }
                else
                {
                    Console.WriteLine("Le nombre est invalide");
                }

                // Division
                // 11 / 5 = 2 reste 1
                // 10 / 5 = 2 reste 0
                //  9 / 5 = 1 reste 4
                int quotient = 11 / 5;  // 2
                int reste = 11 % 5;     // 1 (reste, operateur modulo)

                // 8 / 2  = 4 reste 0 => nombre pair
                // 5 / 2  = 2 reste 1 => nombre impair
                int restePairImpair = entier % 2;
                // if (restePairImpair == 0) // reste 0 => pair
                if (entier % 2 == 0)
                {
                    Console.WriteLine($"Le nombre {entier} est pair!");
                }
                else // reste 1 => impair
                {
                    Console.WriteLine($"Le nombre {entier} est impair!");
                }
            }

            bool estValide = false;
            if (!estValide)
            {
                Console.WriteLine("Erreur : ....");
                return;
            }

            // Lire l'état de la lumiere (vert, jaune, rouge)
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");

            // Lire ...
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");
            Console.WriteLine("Entrer l'etat de la lumiere : ");

            // TODO: Lire la vitesse de l'automobile

            // TODO: Feu 1 - Vérifier vitesse 80km/h 2 sens
            // TODO: Feu 1 - Vérifier vitesse 80km/h 2 sens
            // TODO: Feu 1 - Vérifier vitesse 80km/h 2 sens
            // TODO: Feu 1 - Vérifier vitesse 80km/h 2 sens


            // Exercices
        }
    }
}
