//Un voiture est représentée par :
//Un Modèle qui est une chaine de caractères (Dacia, Toyota, etc)
//Une Plaque d'immatriculation qui est une chaine de caractères qui doit être composée de 9 caractères tout pile (ex : "1-HKF-854")
//Un statut qui est un booléen pour savoir si elle est actuellement disponible ou non
//Un kilometrage qui doit forcément être un nombre positif

using System.Text.RegularExpressions;

public class Voiture
{
    //champs
    private string _immatriculation;
    private Regex _immatriculationRegex = new Regex("^[0-9]-[A-Z](3)-[0-9](3)$");
    
    //propriétés
    public string Modele {  get; set; }

    public string Immatriculation;
    {
         
    }
}