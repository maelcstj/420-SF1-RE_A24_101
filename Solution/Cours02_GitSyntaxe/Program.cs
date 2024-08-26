/*
 * Auteur : Mael Perreault
 * Date : 22 aout 2024
 * Cours 02 - Git et syntaxe de base
 */

namespace Cours02_GitSyntaxe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Mon nom est Mael!");

            // Calcul et affichage de 4 variables
            // camelCaseDesMots
            int nombreEntier = 10 + 20;
            nombreEntier = (nombreEntier + 1) * 10;

            //int nombreEntier = 10 + 20;
            double nombreVirgule = 10.123 + 20.235;
            char unCaractere = '1';
            string chaineCaracters = "Bonjour!";

            Console.WriteLine(nombreEntier);
            Console.WriteLine(nombreVirgule);
            Console.WriteLine(unCaractere);
            Console.WriteLine("Mon beau message :" + chaineCaracters + " ...");

            // Exercice 1
            // Moyenne de 3 nombres


        }
    }
}
