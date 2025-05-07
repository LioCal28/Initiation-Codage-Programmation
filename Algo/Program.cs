// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region Raccourcis
// ceci est un test
#endregion
const string NOM_ROBOT = "Morgan Freeman";
Console.WriteLine($"[{NOM_ROBOT}] Bonjour, comment t'appelles-tu ?");
string nomUtilisateur = Console.ReadLine(); //Récupère le nom d'utilisateur
Console.WriteLine($"[{NOM_ROBOT}] Enchanté {nomUtilisateur}, bienvenue à cette formation !"); //Utilise le nom d'utilisateur + mettre $ avant les guillements tranforme les accolades en code et permet de simplifier l'écriture

int nombre1;
int nombre2;
int temp;

Console.WriteLine("Veuillez entrer un nombre");
nombre1 = int.Parse(Console.ReadLine());
Console.WriteLine("Veuillez entrer un deuxième nombre");
nombre2 = int.Parse(Console.ReadLine());
Console.WriteLine("\nnombre1 = " + nombre1);
Console.WriteLine("nombre2 = " + nombre2);

temp = nombre1;
nombre1 = nombre2;
nombre2 = temp;

Console.WriteLine("\nnombre1 = " + nombre1); //Résultat final
Console.WriteLine("nombre2 = " + nombre2);
