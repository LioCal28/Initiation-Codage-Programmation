using System;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Clear(); // clear la console avant de commencer

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" -----------------------------------------------");
        Console.WriteLine("| Bienvenue au quizz ! Voulez-vous participer ? |");
        Console.WriteLine(" -----------------------------------------------");
        Console.ResetColor();

        int participation;
        int score = 0;
        int nbrQuestion = 1;

        do
        {
            Console.WriteLine("\n(1) Oui     (2) Non");
        } while (!int.TryParse(Console.ReadLine(), out participation) || participation != 1);

        // tableau des questions
        var questions = new (string Enonce, string[] Choix, int BonneReponseIndex)[]
        {
            ("Choisissez l'orthographe correcte :\n... un homme valeureux qui s'est sacrifié pour sa nation.",
                new[] { "Cigit", "Ci-gît", "Cî-gît", "Cî-git" }, 2),
            ("Quelle phrase est correcte ?",
                new[] { "Elles ne s'en sont pas rendu compte.", "Elles ne s'en sont pas rendus compte.",
                        "Elles ne s'en sont pas rendues compte.", "Elles ne s'en sont pas rendue compte." }, 1),
            ("Choisissez l'orthographe correcte. \nIl a dû enlever toutes les ... de sa maison.",
                new[] { "plaintes", "pleinthes", "plinthes", "plintes" }, 3),
            ("Choisissez l'orthographe correcte. \nUne ... de touristes a envahi la ville.",
                new[] { "plhétore", "plétore", "pléthore", "pléthorre" }, 3),
            ("Choisissez l'orthographe correcte. \nIl a fait une remarque ... sur cet acteur.",
                new[] { "dythirambique", "dithyrambique", "dithirambique", "dytirambique" }, 2),
            ("Comment écrit-on le nombre 284 345 en toutes lettres ?",
                new[] {
                    "Deux cent quatre-vingt-quatre mille trois cent quarante-cinq",
                    "Deux cent quatre vingt quatre mille trois cent quarante-cinq",
                    "Deux cent quatre-vingts-quatre mille trois cents quarante-cinq",
                    "Deux-cent quatre-vingt-quatre mille trois-cent quarante-cinq"
                }, 1),
            ("Choisissez l'orthographe correcte.",
                new[] {
                    "des chaussettes oranges et des robes roses",
                    "des chaussettes orange et des robes roses",
                    "des chaussettes orange et des robes rose",
                    "des chaussettes oranges et des robes rose"
                }, 2),
            ("Choisissez l'orthographe correcte. \nNotre entreprise a été ... en 2015.",
                new[] { "créé", "crée", "créée", "créee" }, 3),
            ("Quel nombre est mal écrit ?",
                new[] { "Six mille un", "Huit cent millions", "Huit cent vingt", "Quatre-vingt-quatre" }, 2),
            ("Quel pluriel suivant est correct ?",
                new[] { "des arcs-en-ciels", "des guets-apens", "des orang-outans", "des porc-épics" }, 2)
        };

        // Boucle de questions
        foreach (var q in questions)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n ---------------------------------");
            Console.WriteLine($"Question n°{nbrQuestion} !");
            Console.WriteLine(q.Enonce);
            Console.WriteLine(" ---------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < q.Choix.Length; i++)
            {
                Console.WriteLine($"({i + 1}) {q.Choix[i]}");
            }
            Console.ResetColor();

            int reponse;
            while (!int.TryParse(Console.ReadLine(), out reponse) || reponse < 1 || reponse > q.Choix.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrée invalide. Réessayez !");
                Console.ResetColor();
            }

            if (reponse == q.BonneReponseIndex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bravo ! Question suivante.");
                score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Dommage, ce n'est pas la bonne réponse. La bonne réponse était '{q.Choix[q.BonneReponseIndex - 1]}' !");
            }
            Console.ResetColor();
            nbrQuestion++;
        }

        // Résultat final
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n ---------------------------------");
        if (score <= 5)
        {
            Console.WriteLine($"Votre score est de {score} sur {questions.Length}. Je suis sûr que vous pouvez mieux faire !");
        }
        else if (score < 10)
        {
            Console.WriteLine($"Votre score est de {score} sur {questions.Length}. Vous y étiez presque !");
        }
        else
        {
            Console.WriteLine($"Votre score est de {score} sur {questions.Length}. Vous êtes un véritable crack !");
        }
        Console.WriteLine(" ---------------------------------");
        Console.ResetColor();
    }
}
