string[] listeMots = new string[10];
string[] MOTS = { "Macron", "Le Pen", "Attal", "Bayrou", "Mélenchon", "Chirac", "Hollande", "Sarkozy", "Giscard", "Zemmour" };
Random random = new Random();
int nombre = random.Next(0,10);

Console.WriteLine(MOTS[nombre]);

Console.WriteLine("---------");
Console.WriteLine(MOTS[0]);
Console.WriteLine(MOTS[1]);
Console.WriteLine(MOTS[2]);
Console.WriteLine(MOTS[3]);
Console.WriteLine(MOTS[4]);
Console.WriteLine(MOTS[5]);
Console.WriteLine(MOTS[6]);
Console.WriteLine(MOTS[7]);
Console.WriteLine(MOTS[8]);
Console.WriteLine(MOTS[9]);