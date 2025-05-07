using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

class Program
{
    static string cheminClassement = "classement.txt";

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "🎓 Quizz 🎓";
        string joueur;
        int choix;

        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║           🎓 Bienvenue au Quizz               🎓     ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("║ (1) Commencer le quizz                               ║");
            Console.WriteLine("║ (2) Quitter                                          ║");
            Console.WriteLine("║ (3) Afficher le classement                           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.Write("Votre choix : ");
        } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 3);

        if (choix == 2) return;

        if (choix == 3)
        {
            AfficherClassement();
            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
            Main(args); return;
        }

        Console.Write("\nEntrez votre prénom : ");
        joueur = Console.ReadLine();

        int score = 0;
        int nbrQuestion = 1;

        Stopwatch chrono = new Stopwatch();
        chrono.Start();

        // Questions
        PoserQuestion("À qui doit-on cette citation ? \n'Si la mémoire est à la tête ce que le passé, peut-on y accéder à 6 ?'",
            new string[] { "Dark Vador", "Emmanuel Macron", "Perceval", "Elio Di Rupo" }, 2, ref score, ref nbrQuestion);

        PoserQuestion("À qui doit-on cette citation ? \n'Les hommes de génie sont des météores destinés à brûler pour éclairer leur siècle'",
            new string[] { "Napoléon", "Jules César",
                           "Patrick Sébastien", "Bart Simpson" }, 0, ref score, ref nbrQuestion);

        PoserQuestion("À qui doit-on cette citation ? \n'Ça m'en touche une sans faire bouger l'autre.'",
            new string[] { "François Damiens", "Laurent Baffie", "Jacques Chirac", "Jean-Marie Bigard" }, 2, ref score, ref nbrQuestion);

        PoserQuestion("À qui doit-on cette citation ? \n'C'est pas parce qu'on a rien à dire qu'il faut fermer sa gueule.'",
            new string[] { "Michel Polnareff", "Michel Houellebecq", "Michel Audiard", "Michel Sardou" }, 2, ref score, ref nbrQuestion);

        PoserQuestion("À qui doit-on cette citation ? \n'Le meilleur argument contre la démocratie est un entretien de cinq minutes avec un électeur moyen.'",
            new string[] { "Trump", "Churchill", "Lorenzo l'Empereur du sale", "Oui-Oui" }, 1, ref score, ref nbrQuestion);

        PoserQuestion("À qui doit-on cette citation ? \n'Quand je dis que ma richesse est intérieure, je veux dire que mon argent est dans un coffre.'",
            new string[] { "Philippe Geluck",
                           "Philippe Katerine",
                           "Philippe 1er, roi des belges",
                           "Philippe Hip Hourra" }, 0, ref score, ref nbrQuestion);

        PoserQuestion("À qui doit-on cette citation ? \n'Peu importe que vous ayez du style, une réputation ou de l'argent, si vous n'avez pas bon coeur, vous ne valez rien.'",
            new string[] { "Coluche",
                           "Louis de Funès",
                           "Jean Dujardin",
                           "Pierre Desproges" }, 1, ref score, ref nbrQuestion);

        PoserQuestion("À qui doit-on cette citation ? \n'La différence entre les oiseaux et les hommes politiques, c'est que de temps en temps les oiseaux s'arrêtent de voler.'",
            new string[] { "Dieudonné", "Anne Roumanoff", "Coluche", "Balkany" }, 2, ref score, ref nbrQuestion);

        PoserQuestion("À qui doit-on cette citation ? \n'La beauté est dans les yeux de celui qui regarde.'",
            new string[] { "Charles Baudelaire", "Oscar Wilde", "Marguerite Yourcenar", "Nadar" }, 1, ref score, ref nbrQuestion);

        PoserQuestion("À qui doit-on cette citation ? \n'Tout a déjà été dit cent fois \nEt beaucoup mieux que par moi \nAussi quand j'écris des vers \nC'est que ça m'amuse \nC'est que ça m'amuse \nC'est que ça m'amuse et je vous chie au nez.",
            new string[] { "Arthur Rimbaud", "Boris Vian", "Pierre Desproges", "Elizabeth II d'Angleterre" }, 1, ref score, ref nbrQuestion);

        chrono.Stop();
        TimeSpan temps = chrono.Elapsed;

        // Affichage du score final
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n══════════════════════════════════════════════════════════");
        if (score <= 5)
            Console.WriteLine($"Votre score est de {score} sur {nbrQuestion - 1}. Je suis sûr que vous pouvez mieux faire !");
        else if (score < 10)
            Console.WriteLine($"Votre score est de {score} sur {nbrQuestion - 1}. Vous y étiez presque !");
        else
            Console.WriteLine($"Votre score est de {score} sur {nbrQuestion - 1}. Vous êtes un véritable crack !");
        Console.WriteLine($"Temps écoulé : {temps.Minutes} min {temps.Seconds} sec");
        Console.WriteLine("══════════════════════════════════════════════════════════");
        Console.ResetColor();

        SauvegarderClassement(joueur, score, temps);
        AfficherClassement();

        Console.WriteLine("\nAppuyez sur une touche pour quitter...");
        Console.ReadKey();
    }

    static void PoserQuestion(string question, string[] propositions, int bonneReponse, ref int score, ref int numero)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n╔════════════════════════════════════════════════════════════╗");
        Console.WriteLine($"║ Question n°{numero}                                        ");
        Console.WriteLine("╠════════════════════════════════════════════════════════════╣");
        Console.WriteLine($"║ {question.PadRight(56)}                                  ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
        for (int i = 0; i < propositions.Length; i++)
        {
            Console.WriteLine($"({i + 1}) {propositions[i]}");
        }
        Console.ResetColor();

        int reponse;
        Console.Write("\nVotre réponse : ");
        while (!int.TryParse(Console.ReadLine(), out reponse) || reponse < 1 || reponse > propositions.Length)
        {
            Console.WriteLine("Entrée invalide. Veuillez réessayer.");
        }

        if (reponse - 1 == bonneReponse)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bravo ! Question suivante.");
            score++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Dommage, ce n'est pas la bonne réponse. La bonne réponse était \"{propositions[bonneReponse]}\". Question suivante.");
        }
        Console.ResetColor();
        numero++;
    }

    static void SauvegarderClassement(string nom, int score, TimeSpan temps)
    {
        string ligne = $"{nom}|{score}|{temps}";
        File.AppendAllLines(cheminClassement, new string[] { ligne });
    }

    static void AfficherClassement()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n══════════ 📊 CLASSEMENT DES JOUEURS 📊 ══════════");
        Console.WriteLine("{0,-15} | {1,-10} | {2}", "Joueur", "Score", "Temps");
        Console.WriteLine(new string('-', 45));
        Console.ResetColor();

        if (File.Exists(cheminClassement))
        {
            var lignes = File.ReadAllLines(cheminClassement);
            foreach (var ligne in lignes)
            {
                var parts = ligne.Split('|');
                if (parts.Length == 3)
                    Console.WriteLine("{0,-15} | {1,-10} | {2}", parts[0], parts[1] + "/10", parts[2]);
            }
        }
        else
        {
            Console.WriteLine("Aucun joueur enregistré pour le moment.");
        }
    }
}
