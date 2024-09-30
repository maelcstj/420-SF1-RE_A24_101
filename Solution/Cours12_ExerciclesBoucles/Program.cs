namespace Cours12_ExerciclesBoucles
{
    internal class Program
    {
        const bool ACTIVER_THEORIE = true;

        static void Main(string[] args)
        {
            if (ACTIVER_THEORIE)
            {
                // Demander un nombre tant qu'il est pas valide
                int nombre = 0;
                bool estNombreValide = false;
                while (!estNombreValide)
                {
                    Console.Write("Entrer un nombre : ");
                    string entreeNombre = Console.ReadLine();
                    estNombreValide = int.TryParse(entreeNombre, out nombre);

                    // Afficher une erreur si le nombres est invalide
                    if (!estNombreValide)
                    {
                        Console.WriteLine("Erreur : nombre invalide !");
                    }
                }

                // Écrire une fois valide Le nombre est :
                Console.WriteLine($"Le nombre est : {nombre}");
            }
        }
    }
}
