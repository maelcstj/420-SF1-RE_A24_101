/*
 * Auteur : Mael Perreault
 * Date : 26 aout 2024
 * Cours 03 - Entrées et sorties à la console
 */

using System.Globalization;

namespace Cours03_EntreesSorties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int temperature = 9 / 5;

            int nombreEntier = 214748364; // + -

            // int 32 bits
            // 0 (+) 0000000 00000000 00000000 00000000 (0)
            // 1 (-) 1111111 11111111 11111111 11111111 (2^31 - 1)
            // 2^31 - 1 = 2147483648 - 1

            uint nombreEntierNonSigne = 4294967295;

            // uint 32 bits (unsigned integer = entier non signé)
            // 00000000 00000000 00000000 00000000 (0)
            // 11111111 11111111 11111111 11111111 (2^32 - 1)
            // 2^32 - 1 = 4294967296 - 1

            double nombreVirgule = 10.0;

            // double 64 bits
            // 0 (+) 000000000 (Exposant) 0000....0000 (Nombre a virgule)
            // - 1234 => - 1.234 E 3

            char caractere = 'A';

            // char 16 bits
            // 00000000 00000000 (0) = '\0'
            // 11111111 11111111 (2^16 - 1)
            // 2^16 = 65536 -1 = 65535
            // 0 - 255 => A-Z a-z 0-9 (ASCII)

            string chaine = "Bonjour!";

            // string 16 bits * caractere (char) + 16 bits fin '\0'

            int nombre1 = 9;
            int nombre2 = 5;
            double facteur = (double)nombre1 / nombre2; // 1.8 => 1
            Console.WriteLine(facteur);

            //Ctrl+K,C - Commenter
            //Ctrl+K,U - Uncommenter
            Console.Write("\n\n\nEntrer un nombre : ");
            string entree = Console.ReadLine();
            // '1' '2' '3' \0 => 123
            //int nombreEntre = int.Parse(entree);
            // '1' '.' '2' '3' '4' \0 => 1.234
            double nombreEntre = double.Parse(entree, CultureInfo.InvariantCulture); // 11.5 11,5 (windows fr)
            int nombreAjoute = 10;
            Console.WriteLine($"Le nombre entre + {nombreAjoute,-12} = {nombreEntre + nombreAjoute:0.000}");

        }
    }
}
