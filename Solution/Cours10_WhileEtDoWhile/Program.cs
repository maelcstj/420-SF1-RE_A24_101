namespace Cours10_WhileEtDoWhile
{
    internal class Program
    {
        private const bool ACTIVER_THEORIE = true;

        static void Main(string[] args)
        {

            if (ACTIVER_THEORIE)
            {
                // while
                {
                    string chaineTotale = "";
                    string lettre = ""; // Valeur définie pour while

                    // Tant que la lettre est pas (différente de) -1
                    // -1 : false (arrête)
                    // Reste : true (refaire while)

                    // Effectué 0+ fois
                    while (lettre != "-1")
                    {
                        // Lire une lettre
                        Console.Write("Entrer une lettre (-1 quitter) : ");
                        lettre = Console.ReadLine();

                        // Ajouter a la chaine l'entrée de l'utilisateur en double
                        // Ne pas ajouté la chaine pour l'option de fin de la boucle
                        if (lettre != "-1")
                        {
                            chaineTotale += lettre;
                            chaineTotale += lettre;
                        }

                        // Pour effectuer un travail plusieurs fois, pour chaque entrée
                        // Ajouter dans la boucle
                        // Console.WriteLine($"Chaine en construction : {chaineTotale}");
                    }

                    // Pour effectuer un travail une seul fois avec un résultat
                    // Ajouter après la boucle
                    Console.WriteLine($"Chaine finale : {chaineTotale}");
                }

                // do while
                {
                    string chaineTotale = "";
                    string lettre; // Pas besoin de définir pour do ... while

                    // Effectué 1+ fois
                    do
                    {
                        // Lire une lettre
                        Console.Write("Entrer une lettre (-1 quitter) : ");
                        lettre = Console.ReadLine(); // défini 1ere fois ici

                        // Ajouter a la chaine l'entrée de l'utilisateur en double
                        // Ne pas ajouté la chaine pour l'option de fin de la boucle
                        if (lettre != "-1")
                        {
                            chaineTotale += lettre;
                            chaineTotale += lettre;
                        }

                        // Pour effectuer un travail plusieurs fois, pour chaque entrée
                        // Ajouter dans la boucle
                        // Console.WriteLine($"Chaine en construction : {chaineTotale}");
                    } while (lettre != "-1");

                    // Pour effectuer un travail une seul fois avec un résultat
                    // Ajouter après la boucle
                    Console.WriteLine($"Chaine finale : {chaineTotale}");
                }
            }

            // Exercices ...

        }
    }
}
