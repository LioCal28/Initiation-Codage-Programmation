//Inversion de tableau
//Inverser un tableau : soit un tableau T. Saisir les nombres présents dans ce tableau. Changer de place les éléments de ce tableau de façon à ce que le nouveau tableau soit une sorte de miroir de l'ancien et afficher le nouveau tableau.
//Bonus : Il est possible de le faire en un tableau pour ceux qui veulent se casser le crâne
Console.WriteLine("Veuillez saisir la taille du tableau.");
int tailleTab = int.Parse(Console.ReadLine());
int[] tabOriginal = new int[tailleTab];
Console.WriteLine($"Votre tableau a donc une taille de {tailleTab} cases. Veuillez insérer les éléments du tableau jusqu'à ce qu'il soit plein.");
for (int i = 0; i < tabOriginal.Length; i++)
{
    Console.WriteLine($"\nEntrez le nombre n°{i + 1}");
    tabOriginal[i] = int.Parse(Console.ReadLine());
}
int[] tabInverse = new int[tabOriginal.Length];
for (int i = 0; i < tabOriginal.Length; i++)
{
    tabInverse[i] = tabOriginal[tabOriginal.Length -1 - i];
}
foreach (int i in tabOriginal)
{
    Console.WriteLine($"Voici le tableau original {i}");
}
foreach (int i in tabInverse)
{
    Console.WriteLine($"Voici le tableau inversé {i}");
}