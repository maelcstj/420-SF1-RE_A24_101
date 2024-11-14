/*
 * Auteur : Mael Perreault
 * Date : 14 novembre 2024
 * Cours 21 - Librairies (Bibliothèques)
 */

namespace Cours21_Librairies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecuterTheorie();
            //ExecuterExercice01();
        }

        private static void ExecuterExercice01()
        {
            double resultat1Fonction1 = CalculerFonction1(1.25, 5);
            double resultat2Fonction1 = CalculerFonction1(0.75, 2);
        }

        private static double CalculerFonction1(double v1, int v2)
        {
            double resultat = 0;

            return resultat;
        }

        private static void ExecuterTheorie()
        {
            /*****************************************
            * Librairie Math
            ******************************************/
            // La librairie Math contient des opérations de base de mathématiques

            // --- Constantes --- 
            // pi = 3.1415926535897931
            double pi = Math.PI;
            double calculPi = Math.PI / 4;

            // e = 2.7182818284590451
            double e = Math.E;
            double calculE = Math.E * 2.5;

            // --- Calculs utilitaires ---
            // double valeurAbsolue = Math.Abs(nombre);
            double valeurAbsolue = Math.Abs(-20); // 20

            // double min = Math.Min(nombre1, nombre2);
            double min = Math.Min(27, -8); // -8

            // double max = Math.Max(nombre1, nombre2);
            double max = Math.Max(27, -8); // 27

            // double nombreEntreMinMax = Math.Clamp(nombre, min, max); // [min, max]
            double nombreEntreMinMax = Math.Clamp(115, 0, 100);         // [0, 100] => 100
            double nombreEntreMinMax2 = Math.Clamp(-17, 0, 100);        // [0, 100] => 0
            double nombreEntreMinMax3 = Math.Clamp(75, 0, 100);         // [0, 100] => 75

            // int entierInferieur = (int)Math.Floor(nombreVirgule);
            double doubleInferieur = Math.Floor(59.9999999);            // 59.0
            int entierInferieur = (int)Math.Floor(59.9999999);          // 59

            // int entierSuperieur = (int)Math.Ceiling(nombreVirgule);
            int entierSuperieur = (int)Math.Ceiling(59.0);              // 59
            int entierSuperieur2 = (int)Math.Ceiling(59.0000001);       // 60

            // int entierPlusProche = (int)Math.Round(nombreVirgule);
            int entierPlusProche = (int)Math.Round(59.0000001);         // 59
            int entierPlusProche2 = (int)Math.Round(59.4999999);        // 59
            int entierPlusProche3 = (int)Math.Round(59.5);              // 60
            int entierPlusProche4 = (int)Math.Round(59.9999999);        // 60

            // double arrondiDecimale = Math.Round(nombreVirgule, decimale);
            double arrondi2Decimale = Math.Round(7.72512313, 2);        // 7.73
            double arrondi2Decimale2 = Math.Round(7.72152313, 2);       // 7.72

            double arrondi4Decimale = Math.Round(7.72152313, 4);        // 7.7215

            // --- Calculs scientifiques --- 
            // double puissance = Math.Pow(nombre, exposant);
            double puissance = Math.Pow(2, 4);      // 2 * 2 * 2 * 2 = 16
            double puissance2 = Math.Pow(5, -3);    // 1 / (5 ^ 3) = 1 / 125

            // double racineCarree = Math.Sqrt(nombre);
            double racineCarree = Math.Sqrt(100);   // 10

            // double racineCubique = Math.Cbrt(nombre);
            double racineCubique = Math.Cbrt(8);    // 2 * 2 * 2

            // double racineApproximee = Math.Pow(nombre, 1 / radical);
            double racineErreur = Math.Pow(16, 1 / 4);              // 1 / 4 = 0 reste 1 = 0 => 16^0 = 1
            double racineQuadratique = Math.Pow(16, 1 / (double)4); // Racine 4 = 16 radical 4 = 2 * 2 * 2 * 2

            // double ln = Math.Log(nombre); // Log e = ln
            double ln = Math.Log(1000);

            // double log2 = Math.Log2(nombre);
            double log2 = Math.Log2(1000);

            // double log10 = Math.Log10(nombre);
            double log10 = Math.Log10(1000);

            // double ePuissance = Math.Exp(nombre); // e^nombre = Inverse de Math.Log
            double inverseLn = Math.Exp(Math.Log(1000)); // Revient à 1000

            // --- Calcul des angles en radians --- 
            // Convertir un angle en dégrés en radians
            double angleDegres = 90;
            double radians = angleDegres * Math.PI / 180;

            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);
            double tan = Math.Tan(radians);

            double arcsin = Math.Asin(radians); // sin-1
            double arccos = Math.Acos(radians); // cos-1
            double arctan = Math.Atan(radians); // tan-1

            /*****************************************
             * Génération de nombre aléatoire et tris
             ******************************************/

            // --- Classe Random ---
            // Génération de nombres aléatoires à l'aide d'un nombre initial (seed)
            Random random = new Random(); // seed = heure actuelle

            // Initialisation de la classe Random et du seed aléatoire
            // Même seed génère les mêmes nombres
            Random randomPredefini = new Random(123456789);

            int entierAleatoire = random.Next(20, 30);            // [min, max[
            int entierPredefini = randomPredefini.Next(20, 30);   // [min, max[
            int entierPredefini2 = randomPredefini.Next(20, 30);  // [min, max[
            int entierPredefini3 = randomPredefini.Next(20, 30);  // [min, max[
            int entierPredefini4 = randomPredefini.Next(20, 30);  // [min, max[
            int entierPredefini5 = randomPredefini.Next(20, 30);  // [min, max[

            Console.WriteLine(entierAleatoire);
            Console.WriteLine(entierPredefini);
            Console.WriteLine(entierPredefini2);
            Console.WriteLine(entierPredefini3);
            Console.WriteLine(entierPredefini4);
            Console.WriteLine(entierPredefini5);

            // Doubles 
            double doubleAleatoire = random.NextDouble();   // [0, 1[

            // double doubleMax = max * random.NextDouble();   // [0, max[
            double doubleMax = 8.5 * random.NextDouble();   // [0, 8.5[

            // double doubleMinMax = min + (max – min) * random.NextDouble();   // [min, max[
            double doubleMinMax = 1.2 + (8.5 - 1.2) * random.NextDouble();      // [1.2, 8.5[

            List<int> entiersAleatoires = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int nombre = random.Next(1, 100); // [1, 100[
                entiersAleatoires.Add(nombre);

                Console.Write($"{entiersAleatoires[i]} ");
            }

            List<char> caracteresAleatoires = new List<char>();
            for (int i = 0; i < 20; i++)
            {
                int nombre = random.Next(0, 255); // [0, 26[
                char caractere = (char)('a' + nombre); // 'a' = 97, 'b' = 98
                caracteresAleatoires.Add(caractere);

                Console.Write($"{caracteresAleatoires[i]} ");
            }

            // --- Classe List ---
            // Trier une liste en ordre croissant
            entiersAleatoires.Sort();

            Console.WriteLine();
            for (int i = 0; i < entiersAleatoires.Count; i++)
            {
                Console.Write($"{entiersAleatoires[i]} ");
            }

            // Mélanger le contenu d’une liste avec la librairie avancée Linq
            Random randomList = new Random();
            entiersAleatoires = entiersAleatoires.OrderBy(x => randomList.Next()).ToList();

            Console.WriteLine();
            for (int i = 0; i < entiersAleatoires.Count; i++)
            {
                Console.Write($"{entiersAleatoires[i]} ");
            }
        }
    }
}
