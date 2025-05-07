using System.Text;

Console.OutputEncoding = Encoding.UTF8;

class Program
{
    static void Main(string[] args)
    {
        Quizz monQuizz = new Quizz();

        monQuizz.AjouterQuestion(new Question(
            "Quelle est la capitale de la Belgique ?",
            new string[] { "Berlin", "Londres", "Paris", "Bruxelles" },
            3
            ));

        monQuizz.Lancer();
    }
}