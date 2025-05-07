//Le pion qui bouge :
//Réalisez un algorithme nous permettant de déplacer un pion dans un tableau de 10 éléments. Au début, le pion se trouve dans la première case du tableau. Nous pouvons ensuite le déplacer par la gauche (g), par la droite (d) ou de stopper 
//l'algorithme (q). (rafraichissez la console avec Console.Clear() pour voir votre pion avancer)
//Bonus : Faire un tableau en 2 dimension pour que le pion puisse aussi se déplacer en haut et en bas
string[,] tab = new string[4, 4];
int maxY = 3;
int maxI = 3;
tab[0, 0] = "Pion";
tab[1, 0] = "X";
tab[2, 0] = "X";
tab[3, 0] = "X";
tab[0, 1] = "X";
tab[1, 1] = "X";
tab[2, 1] = "X";
tab[3, 1] = "X";
tab[0, 2] = "X";
tab[1, 2] = "X";
tab[2, 2] = "X";
tab[3, 2] = "X";
tab[0, 3] = "X";
tab[1, 3] = "X";
tab[2, 3] = "X";
tab[3, 3] = "X";

Console.WriteLine("Entrez d pour déplacer le pion vers la droite, g pour le déplacer vers la gauche, u pour aller en haut, l pour aller en bas, ou q pour quitter.");
string commandeUti = Console.ReadLine();

    Console.Clear();
    Console.WriteLine("--------------------------------");
    Console.WriteLine("|      |       |       |       |");
    Console.WriteLine($"| {tab[0, 0]} |   {tab[1, 0]}   |   {tab[2, 0]}   |   {tab[3, 0]}   |");
    Console.WriteLine("|      |       |       |       |");
    Console.WriteLine("|------|-------|-------|-------|");
    Console.WriteLine("|      |       |       |       |");
    Console.WriteLine($"|  {tab[0, 1]}   |   {tab[1, 1]}   |   {tab[2, 1]}   |   {tab[3, 1]}   |");
    Console.WriteLine("|      |       |       |       |");
    Console.WriteLine("|------|-------|-------|-------|");
    Console.WriteLine("|      |       |       |       |");
    Console.WriteLine($"|  {tab[0, 2]}   |   {tab[1, 2]}   |   {tab[2, 2]}   |   {tab[3, 2]}   |");
    Console.WriteLine("|      |       |       |       |");
    Console.WriteLine("|------|-------|-------|-------|");
    Console.WriteLine("|      |       |       |       |");
    Console.WriteLine($"|  {tab[0, 3]}   |   {tab[1, 3]}   |   {tab[2, 3]}   |   {tab[3, 3]}   |");
    Console.WriteLine("|      |       |       |       |");
    Console.WriteLine("--------------------------------");
