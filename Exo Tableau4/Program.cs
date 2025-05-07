//Trouver valeur
//Réalisez un algorithme permettant de rechercher une valeur dans un tableau. Si la valeur se trouve bien dans la tableau, nous affichons sa position. Si la valeur ne se trouve pas dans le tableau, afficher -1.
Console.WriteLine("Quelle taille doit faire le tableau ?");
int tailleTab = int.Parse(Console.ReadLine());
int[] tableau = new int[tailleTab];
Console.WriteLine($"Votre tableau comporte donc {tailleTab} cellules. Veuillez entrer des nombres pour le remplir.");
for (int i = 0; i < tableau.Length; i++)
{
    Console.WriteLine($"Veuillez entrer le nombre n°{i+1}.");
    tableau[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Quelle valeur recherchez-vous dans le tableau ?");
int valeurCherchée = int.Parse(Console.ReadLine());
int position = Array.IndexOf(tableau, valeurCherchée);
if (position >= 0)
{
    Console.WriteLine($"La valeur {valeurCherchée} se trouve à la position {position + 1}.");
}
else
{
    Console.WriteLine("Erreur -1");
}