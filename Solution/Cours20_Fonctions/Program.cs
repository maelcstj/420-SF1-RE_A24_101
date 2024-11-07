/*
 * Auteur : Mael Perreault
 * Date : 7 novembre 2024
 * Cours 20 - Fonctions
 */





namespace Cours20_Fonctions
{
    internal class Program
    {
        private const int FACTEUR_MULTIPLICATION = 50;

        // <Accesseurs> <Type de retour> <Nom de la fonction>(<Parametres>)
        // - Accesseurs : public, private, static***
        // - Type de retour (return)
        //   - void : aucune valeur retournée
        //   - int, double, string, bool, int[], List<int>
        // - Nom de la fonction
        //   - Verbe action + complément descriptif
        //   - Bien : AfficherPointages, CalculerMoyenne, DessinerRectangle, LireOperation
        //   - Mauvais : Afficher, Nombre, A, B, C, CalculerNombre
        //   - Truc : se fier a vos commentaires
        //   - Truc 2 : mettre des commentaires
        static void Main(string[] args)
        {
            ExecuterTheorie();
            //ExecuterExercice01();
        }

        private static void ExecuterExercice01()
        {
            //// Tester vos fonctions de l'exercice 01
            //int minimum1 = TrouverMinimum(10.2, 5);
            //Console.WriteLine($"Minimum entre 10 et 5 :  {minimum1}");

            //int minimum2 = TrouverMinimum(-30, 45);
            //Console.WriteLine($"Minimum entre -30 et 45 : {minimum2}");

        }

        private static void ExecuterTheorie()
        {
            Console.WriteLine("Hello, World!");
            AfficherSommes();

            List<int> entiers = new List<int>() { 10, 20, 30 };
            List<int> pointeurEntiers = entiers;
            //List<int> pointeurEntiers = new List<int>();

            pointeurEntiers.Add(40);

            // entiers contient : 10, 20, 30, 40

            AfficherListe("Liste entiers : ", entiers);
            AfficherListe("Liste pointeurEntiers : ", pointeurEntiers);

            AjouterListe(pointeurEntiers, 100);

            AfficherListe("Liste entiers : ", entiers);
            AfficherListe("Liste pointeurEntiers : ", pointeurEntiers);

            int nombre1 = 10;
            int nombre2 = 20;
            int nombre3 = 30;
            MultiplierParConstante(nombre1, ref nombre2, out nombre3, FACTEUR_MULTIPLICATION);

            Console.WriteLine($"Nombre 1 : {nombre1}");
            Console.WriteLine($"Nombre 2 (ref) : {nombre2}");
            Console.WriteLine($"Nombre 3 (out) : {nombre3}");

            Console.WriteLine("Fin du programme");
        }

        // Variables normales sont passée par copie, les changements ne sont pas conservés
        // Pour modifier les valeur de la fonction originale, utiliser ref
        private static void MultiplierParConstante(int nombre1, ref int nombre2, out int nombre3, int facteur)
        {
            nombre1 *= facteur;
            nombre2 *= facteur;
            nombre3 = facteur; // out : valeur est non initialisé
        }

        // Modifier la liste dans la fonction, modifie la liste partout
        // Parce les listes utilisent new, donc pointent toutes sur le même espace en mémoire
        private static void AjouterListe(List<int> liste, int valeur)
        {
            liste.Add(valeur);
        }

        private static void AfficherListe(string titre, List<int> liste)
        {
            Console.Write(titre);

            for (int i = 0; i < liste.Count; i++)
            {
                Console.Write($"{liste[i]} ");
            }

            Console.WriteLine();
        }

        private static void AfficherSommes()
        {
            int resultat = AdditionnerEntiers(10, 5);
            Console.WriteLine($"10 + 5 = {resultat}");

            int resultat2 = AdditionnerEntiers(99, -25);
            Console.WriteLine($"99 + -25 = {resultat2}");
        }

        static int AdditionnerEntiers(int entier1, int entier2)
        { 
            int somme = entier1 + entier2;
            return somme;
        }
    }
}
