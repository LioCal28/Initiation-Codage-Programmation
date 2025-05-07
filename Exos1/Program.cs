// See https://aka.ms/new-console-template for more information
//Exercice 1 :
//Demandez à l'utilisateur 
//De saisir le prix d'une petite frite
//De saisir le nombre de petites frites qu'il veut
//L'algo vous donnera en résultat le prix total de votre commande
//Bonus : Rajouter à ce prix total la TVA à 25%

const string NOM_CHEF = "Maître Kebabier";
Console.WriteLine($"[{NOM_CHEF}] Bonjour ! Combien coûte une petite frite ?");
double prixFrite = double.Parse(Console.ReadLine()); //récupère le prix de la frite
Console.WriteLine($"[{NOM_CHEF}] Ça fera {prixFrite} euros. Et combien en veux-tu ?");
double qtéFrite = double.Parse(Console.ReadLine()); //récupère la quantité de frites
double prixTotalFrite = prixFrite * qtéFrite; //calcule le prix total : nombre de frites * prix à l'unité
Console.WriteLine($"[{NOM_CHEF}] Tu en veux {qtéFrite} ? Au prix de {prixFrite} par petite frite, ça te coûtera {prixTotalFrite} euros.");
double TVA = 1.25; // TVA de 25%
double prixTotalFriteTVA = prixTotalFrite * TVA ; //applique la TVA
Console.WriteLine($"[{NOM_CHEF}] Ah et j'ai failli oublier la TVA ! En la comptant, ça te coûtera {prixTotalFriteTVA} !");