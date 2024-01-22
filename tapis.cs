using System;

// Programme pour dessiner un tapis avec une diagonale
class Program
{
    // Fonction pour dessiner un tapis avec une diagonale
    static void DessinerTapis(int taille)
    {
        // Dessiner la bordure supérieure
        Console.WriteLine("+" + new string('-', taille) + "+");

        // Dessiner le corps du tapis
        for (int i = 0; i < taille; i++)
        {
            Console.Write("|");
            Console.Write(new string('#', taille - i - 1));
            Console.Write(" ");
            if (i > 0) // Ajouter la partie droite de la diagonale
            {
                Console.Write(new string('#', i));
            }
            Console.WriteLine("|");
        }

        // Dessiner la bordure inférieure
        Console.WriteLine("+" + new string('-', taille) + "+");
    }

    // Fonction principale pour appeler la fonction DessinerTapis
    static void Main()
    {
        // Appels séparés de la fonction DessinerTapis pour différentes tailles
        Console.WriteLine("Test avec la taille 6:");
        DessinerTapis(6);
        Console.WriteLine(); // Séparation entre les tests

        Console.WriteLine("Test avec la taille 10:");
        DessinerTapis(10);
        Console.WriteLine(); // Séparation entre les tests

        Console.WriteLine("Test avec la taille 15:");
        DessinerTapis(15);
        Console.WriteLine(); // Séparation entre les tests

        Console.WriteLine("Test avec la taille 3:");
        DessinerTapis(3);
        Console.WriteLine(); // Séparation entre les tests

        Console.WriteLine("Test avec la taille 8:");
        DessinerTapis(8);
        Console.WriteLine(); // Séparation entre les tests
    }
}
