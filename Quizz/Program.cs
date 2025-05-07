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
        PoserQuestion("Choisissez l'orthographe correcte :\n... un homme valeureux qui s'est sacrifié pour sa nation.",
            new string[] { "Cigit", "Ci-gît", "Cî-gît", "Cî-git" }, 2, ref score, ref nbrQuestion);

        PoserQuestion("Quelle phrase est correcte ?",
            new string[] { "Elles ne s'en sont pas rendu compte.", "Elles ne s'en sont pas rendus compte.",
                           "Elles ne s'en sont pas rendues compte.", "Elles ne s'en sont pas rendue compte." }, 0, ref score, ref nbrQuestion);

        PoserQuestion("Choisissez l'orthographe correcte.\nIl a dû enlever toutes les ... de sa maison.",
            new string[] { "plaintes", "pleinthes", "plinthes", "plintes" }, 2, ref score, ref nbrQuestion);

        PoserQuestion("Choisissez l'orthographe correcte.\nUne ... de touristes a envahi la ville.",
            new string[] { "plhétore", "plétore", "pléthore", "pléthorre" }, 2, ref score, ref nbrQuestion);

        PoserQuestion("Choisissez l'orthographe correcte.\nIl a fait une remarque ... sur cet acteur.",
            new string[] { "dythirambique", "dithyrambique", "dithirambique", "dytirambique" }, 1, ref score, ref nbrQuestion);

        PoserQuestion("Comment écrit-on le nombre 284 345 en toutes lettres ?",
            new string[] { "Deux cent quatre-vingt-quatre mille trois cent quarante-cinq",
                           "Deux cent quatre vingt quatre mille trois cent quarante-cinq",
                           "Deux cent quatre-vingts-quatre mille trois cents quarante-cinq",
                           "Deux-cent quatre-vingt-quatre mille trois-cent quarante-cinq" }, 0, ref score, ref nbrQuestion);

        PoserQuestion("Choisissez l'orthographe correcte.",
            new string[] { "des chaussettes oranges et des robes roses",
                           "des chaussettes orange et des robes roses",
                           "des chaussettes orange et des robes rose",
                           "des chaussettes oranges et des robes rose" }, 1, ref score, ref nbrQuestion);

        PoserQuestion("Choisissez l'orthographe correcte.\nNotre entreprise a été ... en 2015.",
            new string[] { "créé", "crée", "créée", "créee" }, 2, ref score, ref nbrQuestion);

        PoserQuestion("Quel nombre est mal écrit ?",
            new string[] { "Six mille un", "Huit cent millions", "Huit cent vingt", "Quatre-vingt-quatre" }, 1, ref score, ref nbrQuestion);

        PoserQuestion("Quel pluriel suivant est correct ?",
            new string[] { "des arcs-en-ciels", "des guets-apens", "des orang-outans", "des porc-épics" }, 1, ref score, ref nbrQuestion);

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
