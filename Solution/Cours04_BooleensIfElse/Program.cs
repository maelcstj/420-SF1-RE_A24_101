/*
 * Auteur : Mael Perreault
 * Date : 29 aout 2024
 * Cours 04 - Booléens et if/else
 */

namespace Cours04_BooleensIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Opérateurs comparaison
            // >, <, >=, <=, ==, !=
            bool estVrai = true; // 1, -1, autres valeurs
            bool estFaux = false; // 0

            Console.WriteLine(estVrai);
            Console.WriteLine(estFaux);

            Console.WriteLine("Comparaisons sur le meme type");
            Console.WriteLine(5 == 5);
            Console.WriteLine(5.0 == 5.0);
            Console.WriteLine('5' == '5');
            Console.WriteLine("5" == "5");

            Console.WriteLine("Comparaisons des types differents");
            Console.WriteLine(5 == 5.0); // int == double
            Console.WriteLine(5 == '5'); // int == char => 5 == 53
            //Console.WriteLine(5 == "5"); // int == string => 5 == '5' '\0'
            Console.WriteLine(5.ToString() == "5"); // 5 => '5' '\0' == '5' '\0'
            //Console.WriteLine("5" == '5'); // string == char => '5' '\0' == '5'
            Console.WriteLine("5" == '5'.ToString()); // '5' => '5' '\0' == '5' '\0'

            Console.WriteLine("Comparaisons de chaines de caracteres");
            Console.WriteLine("bonjour" == "bonjour"); // true
            Console.WriteLine("bonjour" == "Bonjour"); // false
            Console.WriteLine("bonjour" == "bonjour "); // false
            Console.WriteLine("bonjour" == " bonjour"); // false
            Console.WriteLine("bonjour" == "bon jour"); // false
            Console.WriteLine("bonjour" == "bonjours"); // false

            // Opérateurs logiques
            // et (and) : && les 2 doivent etre true
            // ou (or) : || au moins un des 2 ou les 2 doivent etre true
            // non (not) : !( condition ) inverser true devient false ou false devient true

            Console.Write("Entrer un nombre : ");
            string entreeNombre = Console.ReadLine();
            int nombre = int.Parse(entreeNombre);

            bool estPlusQue10 = nombre > 10;
            bool estEntre10Et20 = nombre >= 10 && nombre <= 20;
            bool estPlusQue10OuMoinsQue20 = nombre >= 10 || nombre <= 20;
            bool nestPasEntre10Et20 = !(nombre >= 10 && nombre <= 20);

            Console.WriteLine(estPlusQue10);
            Console.WriteLine(estEntre10Et20);
            Console.WriteLine(estPlusQue10OuMoinsQue20);
            Console.WriteLine(nestPasEntre10Et20);

            if (nombre >= 0 && nombre <= 100) // -30 >= 0 => false
            {
                // travail si condition est true
                Console.WriteLine($"Le nombre {nombre} est positif");
            }
            else
            {
                // travail si condition est false
                Console.WriteLine($"Le nombre {nombre} est negatif");
            }
            // fin apres un des 2 travail

            // Exercice 1
            // A. bool exercice1a = 50 < 100 && 75 > 50
            // A. bool exercice1a = true && 75 > 50
            // A. bool exercice1a = true && true
            // A. bool exercice1a = true


        }
    }
}
