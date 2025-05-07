using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Quizz
{
    private List<Question> questions;
    private int score;

    public Quizz()
    {
        questions = new List<Question>();
        score = 0;
    }

    public void AjouterQuestion(Question question)
    { 
        questions.Add(question);
    }

    public void Lancer()
    {
        for (int i = 0; i < questions.Count; i++)
        {
            var q = questions[i];
            Console.WriteLine($"Questions {i + 1} : {q.Text}");
            for (int j = 0; j < q.Choice.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {q.Choice[j]}");
            }
            Console.WriteLine("Votre réponse (numéro) : ");
            int reponse;
            while (!int.TryParse(Console.ReadLine(), out reponse) || reponse < 1 || reponse > q.Choice.Length)
            {
                Console.WriteLine("Entrée invalide. Veuillez réessayer.");
            }

            if (q.EstBonneReponse(reponse - 1))
            {
                Console.WriteLine("Bonne réponse !");
                score++;
            }
            else
            {
                Console.WriteLine($"Mauvaise réponse. La bonne réponse était {q.Choice[q.IndexBonneReponse]}");
            }

            Console.WriteLine();
        }
        Console.WriteLine($"Quizz terminé ! Score final : {score}/{questions.Count}");
    }
    }