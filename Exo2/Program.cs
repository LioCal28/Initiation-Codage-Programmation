// See https://aka.ms/new-console-template for more information
//Inverser deux variables sans variable temporaire (avec des opérateurs simples)
Console.WriteLine("Veuillez entrer un nombre.");
double nombre1 = double.Parse(Console.ReadLine());
Console.WriteLine("Veuillez entrer un deuxième nombre.");
double nombre2 = double.Parse(Console.ReadLine());
Console.WriteLine("\nnombre1 = " + nombre1);
Console.WriteLine("nombre2 = " + nombre2);

nombre1 = nombre1 + nombre2;
nombre2 = nombre1 - nombre2;
nombre1 = nombre1 - nombre2;

Console.WriteLine("\nRésultat final : \nnombre1 = " + nombre1); // résultat final après échange
Console.WriteLine("nombre2 = " + nombre2);
