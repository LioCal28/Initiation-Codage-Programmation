//Exercice moyenne des scores  (page 127) :
//Écrire un algorithme demandant à l’utilisateur le nombre de joueurs (max 10 joueurs). Ensuite, l’algorithme doit demander à l’utilisateur le score de chaque joueur. Une fois ceci fini, il faut afficher la moyenne des scores. 
Console.WriteLine("Combien de joueurs avez-vous dans votre partie ?");
int nbrJoueurs = int.Parse(Console.ReadLine());
while (nbrJoueurs > 10 || nbrJoueurs < 1)
{
    Console.WriteLine($"Vous avez choisi {nbrJoueurs} joueurs. Veuillez entrer un nombre de joueurs compris entre 1 et 10.");
    nbrJoueurs = int.Parse(Console.ReadLine());
}
int[] tabJoueurs = new int[nbrJoueurs];
Console.WriteLine($"Vous avez donc {nbrJoueurs} joueurs dans votre partie. Veuillez entrer les scores des joueurs afin d'obtenir la moyenne.");
for (int i = 0; i < tabJoueurs.Length; i++)
{
    Console.WriteLine($"Entrez le score du joueur n°{i + 1}");
    tabJoueurs[i] = int.Parse(Console.ReadLine());
}
int sum = tabJoueurs.Sum();
Console.WriteLine($"La moyenne des {nbrJoueurs} joueurs est de {sum / nbrJoueurs}");