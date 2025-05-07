Console.WriteLine("Bonjour ! Voulez-vous une boisson ? Veuillez taper Oui ou Non.");
string answer = Console.ReadLine();
bool choice = answer.Trim().ToLower() == "oui";

int qtéFanta = 3;
int qtéIce = 5;
int qtéSch = 2;

while ((qtéFanta > 0 || qtéIce > 0 || qtéSch > 0) && choice)
{
    Console.WriteLine("Quelle boisson voulez-vous ? Fanta, Ice Tea, Schweppes ?");
    string boisson = Console.ReadLine();
    Console.WriteLine($"Voici votre {boisson} !");
    if (boisson == "fanta" && qtéFanta > 0)
        qtéFanta--;
    if (boisson == "ice tea" && qtéIce > 0)
        qtéIce--;
    if (boisson == "schweppes" && qtéSch > 0)
        qtéSch--;
    if (boisson == "fanta" && qtéFanta == 0)
        Console.WriteLine($"Désolé ! Nous n'avons plus de {boisson} en stock.");
    if (boisson == "ice tea" && qtéIce == 0)
        Console.WriteLine($"Désolé ! Nous n'avons plus de {boisson} en stock.");
    if (boisson == "schweppes" && qtéSch == 0)
        Console.WriteLine($"Désolé ! Nous n'avons plus de {boisson} en stock.");

    Console.WriteLine("Voulez-vous une autre boisson ?");
}

Console.WriteLine("Merci et bonne journée !");
