//Le pion qui bouge :
//Réalisez un algorithme nous permettant de déplacer un pion dans un tableau de 10 éléments. Au début, le pion se trouve dans la première case du tableau. Nous pouvons ensuite le déplacer par la gauche (g), par la droite (d) ou de stopper 
//l'algorithme (q). (rafraichissez la console avec Console.Clear() pour voir votre pion avancer)
//Bonus : Faire un tableau en 2 dimension pour que le pion puisse aussi se déplacer en haut et en bas
int rows = 10;
int cols = 10;
int x = 0, y = 0; // Position initiale du pion (en haut à gauche)

while (true) // Boucle principale du jeu
{
    Console.Clear();

    // Affichage du tableau avec le pion
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (i == y && j == x)
                Console.Write("P ");
            else
                Console.Write(". ");
        }
        Console.WriteLine();
    }

    // Instructions utilisateur
    Console.WriteLine("\nDéplacez le pion : (g = gauche, d = droite, h = haut, b = bas, q = quitter)");
    char input = Console.ReadKey().KeyChar;

    // Gestion des mouvements
    if (input == 'q')
    {
        break; // Sort de la boucle while (true)
    }
    else if (input == 'g' && x > 0)
    {
        x--;
    }
    else if (input == 'd' && x < cols - 1)
    {
        x++;
    }
    else if (input == 'h' && y > 0)
    {
        y--;
    }
    else if (input == 'b' && y < rows - 1)
    {
        y++;
    }
}

Console.WriteLine("\nProgramme terminé. Merci d'avoir joué !");
    