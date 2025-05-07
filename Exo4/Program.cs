// See https://aka.ms/new-console-template for more information
Console.WriteLine(" -------------------");
Console.WriteLine("|  Année Bissextile  |");
Console.WriteLine(" -------------------");
Console.WriteLine("Quelle année devons-nous vérifier ?");
int year = int.Parse(Console.ReadLine());

if (year % 4 == 0 || year % 400 == 0)
{
    Console.WriteLine($"{year} ? Cette année est bissextile !");
}
else if (year % 100 != 0)
{
    Console.WriteLine($"{year} ? Cette année n'est pas bissextile !");
}
else
{
    Console.WriteLine($"{year} ? Cette année n'est pas bissextile !");
}