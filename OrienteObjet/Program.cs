//Un voiture est représentée par :
//Un Modèle qui est une chaine de caractères (Dacia, Toyota, etc)
//Une Plaque d'immatriculation qui est une chaine de caractères qui doit être composée de 9 caractères tout pile (ex : "1-HKF-854")
//Un statut qui est un booléen pour savoir si elle est actuellement disponible ou non
//Un kilometrage qui doit forcément être un nombre positif

//Elle possède 3 méthodes : 
//Une méthode qui permet d'afficher les informations d'une voiture (plaque, modèle, disponible ou non, kilométrage)
//Une méthode qui permet de louer une voiture (on doit alors vérifier qu'elle soit bien disponible pour la louer et si on peut la louer, son statut doit devenir indisponible)
//Une méthode pour rendre la voiture qui demandera un nombre de km effectués. On ajoute alors le nombre de km aux km existants et on repasse la voiture en disponible)

//Créez quelques voitures pour effectuer vos tests
//On ne doit pas pouvoir entrer une plaque qui ne fait pas 9 caractères
//On ne doit pas pouvoir entrer un kilométrage négatif
//Quand on loue, on ne doit pas pouvoir emprunter une voiture pas dispo
//Quand on rend la voiture, le nombre de km effectués ne doit être négatif

//using System.Text;
//Console.OutputEncoding = Encoding.UTF8;

//Console.WriteLine("Premier véhicule");
//Voiture voiture1 = new Voiture();
//Console.WriteLine($"\nLe nom du produit venant d'être créé est : {voiture1.Name}");

//Console.WriteLine("\nRemplissage du nom du produit...");
//voiture1.Name = "Toyota";
//Console.WriteLine($"Le nom du produit est : {voiture1.Name}");

Console.WriteLine("Bienvenue au garage de ...");
Console.WriteLine("Ajout de la première voiture dans notre database");
Voiture v1 = new Voiture();
v1.Modele = "Dacia Sandero";

Console.WriteLine("Ajout de la deuxième voiture dans notre database");
Voiture v2 = new Voiture();
v2.Modele = "Toyota Rav4";











