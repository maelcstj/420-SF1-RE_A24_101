namespace Cours10_WhileEtDoWhile
{
    internal class Program
    {
        private const bool ACTIVER_THEORIE = true;

        static void Main(string[] args)
        {
            // Tant que la lettre est pas (différente de) -1
            // -1 : false (arrête)
            // Reste : true (refaire while)
            if (ACTIVER_THEORIE)
            {
                {
                    string chaineTotale = "";
                    string lettre = ""; // non défini!

                    // Effectué 0+ fois
                    while (lettre != "-1")
                    {
                        // Lire une lettre
                        Console.Write("Entrer une lettre (-1 quitter) : ");
                        lettre = Console.ReadLine();

                        // Ajouter a la chaine l'entrée de l'utilisateur
                        if (lettre != "-1")
                        {
                            chaineTotale += lettre;
                            chaineTotale += lettre;
                        }

                        // Console.WriteLine($"Chaine en construction : {chaineTotale}");
                    }

                    // Résultat hors de la boucle (affiché un seule fois)
                    Console.WriteLine($"Chaine finale : {chaineTotale}");
                }

                // do while
                {
                    string chaineTotale = "";
                    string lettre; // pas besoin de définir

                    // Effectué 1+ fois
                    do
                    {
                        // Lire une lettre
                        Console.Write("Entrer une lettre (-1 quitter) : ");
                        lettre = Console.ReadLine(); // défini 1ere fois ici

                        // Ajouter a la chaine l'entrée de l'utilisateur
                        if (lettre != "-1")
                        {
                            chaineTotale += lettre;
                            chaineTotale += lettre;
                        }

                        // Console.WriteLine($"Chaine en construction : {chaineTotale}");
                    } while (lettre != "-1");

                    // Résultat hors de la boucle (affiché un seule fois)
                    Console.WriteLine($"Chaine finale : {chaineTotale}");
                }
            }

            // Exercices ...

        }
    }
}
