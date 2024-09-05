/*
 * Auteur : Mael Perreault
 * Date : 5 septembre 2024
 * Cours 05 - Scope et Switch
 */

namespace Cours05_ScopeSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        { // Scope 1 - debut

            {
                int a = 10;
                int b = 20;

                Console.WriteLine(a);
                Console.WriteLine(b);

                { // Scope 2 - debut
                  //int a = 30; // erreur, existe deja dans Scope 1

                    int c = 40;

                    Console.WriteLine(a); // Scope 1
                    Console.WriteLine(c);
                } // Scope 2 - fin

                { // Scope 3 - debut
                  //int a = 30; // erreur, existe deja dans Scope 1

                    int c = 50;

                    Console.WriteLine(a); // Scope 1
                    Console.WriteLine(c);
                } // Scope 3 - fin


                Console.Write("Nombre : ");
                string entreeNombre = Console.ReadLine();
                int nombre = int.Parse(entreeNombre);

                int calcul = 0;

                if (nombre > 100)
                {
                    Console.WriteLine("Nombre plus que 100");
                    calcul = nombre * 100;
                }
                else if (nombre > 0)
                {
                    Console.WriteLine("Nombre positif");
                    calcul = nombre * 10;
                }
                else if (nombre < -100)
                {
                    Console.WriteLine("Nombre moins que -100");
                }
                else if (nombre < 0)
                {
                    Console.WriteLine("Nombre negatif");
                }
                else
                {
                    Console.WriteLine("Nombre zero");
                }

                Console.WriteLine($"Le resultat du calcul : {calcul}");

                Console.Write("Membre (or, argent, bronze) : ");
                string membre = Console.ReadLine();

                if (membre == "or")
                {

                }
                else if (membre == "argent")
                {

                }
                else if (membre == "bronze")
                {

                }
                else
                {
                    // Pas de rabais
                }

                switch (membre)
                {
                    case "o":
                    case "O":
                    case "or":
                    case "OR":
                        {
                            int points = 10 * nombre;
                            Console.WriteLine(points);
                        }
                        break;
                    case "a":
                    case "A":
                    case "argent":
                    case "ARGENT":
                        //case "bronze": // erreur, deja present dans switch
                        {
                            int points = 8 * nombre;
                            Console.WriteLine(points);
                        }
                        break;
                    case "b":
                    case "B":
                    case "bronze":
                    case "BRONZE":
                        Console.WriteLine(5);
                        break;
                    default:
                        Console.WriteLine("Type de membre non valide");
                        break;
                }

                // 1) ...
                // 2) ...
                // 3) ...
                switch (nombre) // int
                {
                    case 1: break;
                    //case '1': break; // erreur, int et char
                    //case "1": break; // erreur, int et string
                    case 2: break;
                    case 3: break;
                    default: break;
                }

                // 1) ...
                // 2) ...
                // 3) ...
                switch (entreeNombre) // string
                {
                    case "1": break;
                    //case 1: break; // erreur, string et int
                    //case '1': break; // erreur, string et char
                    case "2": break;
                    case "3": break;
                    default: break;
                }
            }

            // Debut des exercices


        } // Scope 1 - fin
    }
}
