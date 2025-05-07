// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quelle boisson désirez-vous ? Schweppes, Fanta, Ice Tea ?");
string boissonChoisie = Console.ReadLine();
int qtéFanta = 3;
int qtéIce = 5;
int qtéSch = 1;

do
{
    Console.WriteLine($"Cling ! Voici votre {boissonChoisie} ! Voulez-vous une autre boisson ?\nVeuillez taper Oui ou Non.");
    bool ouiNon = int.Parse(Console.ReadLine());
} while (qtéFanta > 0 || qtéIce > 0 || qtéSch > 0);

if (qtéFanta == 0 && ouiNon == "Oui")
{

}

