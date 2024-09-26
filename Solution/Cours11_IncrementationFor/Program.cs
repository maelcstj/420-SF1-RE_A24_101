namespace Cours11_IncrementationFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opérateurs incrématation +1 -1 += 1
            // Pré-incrémentation  : ++nombre, --nombre 
            // Post-incrémentation : nombre++, nombre--

            int pre = 0;
            int post = 0;

            // Différence quand utiliser opérateurs dans une autre opération
            Console.WriteLine($"Pre : {++pre}");    // incremente (0 + 1) et utilise (1)
            Console.WriteLine($"Post : {post++}");  // utilise (0) et incremente (0 + 1)

            Console.WriteLine($"Pre apres : {pre}");    // 1
            Console.WriteLine($"Post apres : {post}");  // 1

            // Aucune différence, pas utilisation
            ++pre;
            post++;

            Console.WriteLine($"Pre apres : {pre}");    // 2
            Console.WriteLine($"Post apres : {post}");  // 2

            // Boucle for
            // for (déclaration itérateur; condition; incrémentation)
            for (int nombre = 1; nombre <= 5; nombre++)
                {
                    // Travail de la boucle
                    Console.Write(nombre);
                    Console.Write(" ");
                }

            // Équivalent en boucle while
            {
                int nombre = 1; // Déclaration itérateur (nombre)
                while (nombre <= 5) // condition
                {
                    // Travail de la boucle
                    Console.Write(nombre);
                    Console.Write(" ");

                    nombre++; // Incrémentation, sinon boucle infinie
                }
            }

            //Variables
            // int nombre = 1, 2, 3, 4, 5, 6

            for (int nombre = 1; nombre <= 5; nombre++)
            {
                Console.Write(nombre);
                Console.Write(" ");
            }

            // Sorties
            // 1 2 3 4 5 
            


            // Comment ecrire une boucle for

            // Identifier travail a effectuer plusieurs fois
            Console.WriteLine("Bonjour!");

            // Itérations : 14
            const int NOMBRE_ETUDIANTS_101 = 14;

            // Englober le travail dans une boucle for
            for (int nombre = 1; nombre <= 14; nombre++)
            {
                // int matricule = 2400000 + nombre;
                int matricule = (1000 * nombre) + nombre;
                Console.WriteLine($"Bonjour etudiant #{matricule}!");

                if (nombre % 5 == 0) // Divisible par 5 sans reste 1 2 3 4 5 
                {
                    Console.WriteLine("Bonjour fait pour 5 etudiants!");
                }
            }

            // Boucles imbriquées
            // 1 2 3 4 5
            // 1 2 3 4 5
            // 1 2 3 4 5

            // Commencer par faire le travail d'une seule ligne
            //for (int nombre = 1; nombre <= 5; nombre++)
            //{
            //    Console.Write(nombre);
            //    Console.Write(" ");
            //}

            //Console.WriteLine();

            //// Se repéter pour tester
            //for (int nombre = 1; nombre <= 5; nombre++)
            //{
            //    Console.Write(nombre);
            //    Console.Write(" ");
            //}

            //Console.WriteLine();

            //for (int nombre = 1; nombre <= 5; nombre++)
            //{
            //    Console.Write(nombre);
            //    Console.Write(" ");
            //}

            //Console.WriteLine();

            // Englober le travail avec une nouvelle boucle
            for (int ligne = 0; ligne < 3; ligne++)
            {
                // Afficher une ligne
                for (int nombre = 1; nombre <= 5; nombre++)
                {
                    Console.Write(ligne); // ligne
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
