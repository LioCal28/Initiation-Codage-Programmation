Console.WriteLine("Qui est l'actuel président de la République ?");
string presiRepu = Console.ReadLine();
bool Macron = presiRepu.Trim().ToLower() == "macron";

if (Macron == true)
{
    Console.WriteLine("MACRON EXPLOSION");
    Console.WriteLine("Désirez-vous plus d'explosion ? Oui ou non ?");
    string moreExplo = Console.ReadLine();

    if (moreExplo.Trim().ToLower() == "oui")
        Console.WriteLine("MACRON EXPLOSIOOOOOON");

    else if (moreExplo.Trim().ToLower() != "oui")
        Console.WriteLine("Bon d'accord, assez d'explosions.");
}
else
{
    Console.WriteLine("Ce n'est pas Macron, pas d'explosion");
}
if (Macron == true)
{
    Console.WriteLine("À qui est ce projet ?");
    string projet = Console.ReadLine();
    if (projet != null) ;
    Console.WriteLine("C'EST NOTRE PROJET");
}