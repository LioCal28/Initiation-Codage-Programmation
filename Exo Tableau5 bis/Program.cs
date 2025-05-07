//Inversion de tableau
//Inverser un tableau : soit un tableau T. Saisir les nombres présents dans ce tableau. Changer de place les éléments de ce tableau de façon à ce que le nouveau tableau soit une sorte de miroir de l'ancien et afficher le nouveau tableau.
//Bonus : Il est possible de le faire en un tableau pour ceux qui veulent se casser le crâne

int rows = 10;
int columns = 10;
int x = 0; 
int y = 0; //position de départ du pion

    while (true)
    {
        Console.Clear();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (i == y && j == x)
                    Console.Write("P");
                else
                    Console.Write(".");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("\nDéplacez le pion : (g = gauche, d = droite, h = haut, b = bas, q = quitter)");
    char input = Console.ReadKey().KeyChar;
    {
        if (input == 'q') 
            break;

        Console.WriteLine("Vous êtes prisonnier de la console.");


        else if (input == 'g' && x > 0) x--;
        else if (input == 'd' && x < columns - 1) x++;
        else if (input == 'h' && y > 0) y--;
        else if (input == 'b' && y < rows - 1) y++;
    }



