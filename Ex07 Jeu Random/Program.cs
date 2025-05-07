Console.WriteLine(" -*-*-*-*-*-*-*-*-*-*-*-*-*");
Console.WriteLine("| Bienvenue au Juste Prix ! |");
Console.WriteLine(" *-*-*-*-*-*-*-*-*-*-*-*-*-");

Console.WriteLine("Voulez-vous jouer en mode Facile, Moyen ou Difficile ?");
string mode = Console.ReadLine().Trim().ToLower();

if (mode == "facile")
{
    Console.WriteLine($"C'est parti pour le mode {mode} ! Veuillez entrer un nombre de 1 à 10.");
    int nbr = new Random().Next(0, 10);
    int guessesLeft = 4;

    while (guessesLeft > 0)
    {
        int nbrGuess = int.Parse(Console.ReadLine());

        if (nbr > nbrGuess)
        {
            Console.WriteLine($"Le nombre recherché est supérieur à {nbrGuess} ! {guessesLeft} essai(s) restants !");
            guessesLeft--;
        }
        if (nbr < nbrGuess)
        {
            Console.WriteLine($"Le nombre recherché est inférieur à {nbrGuess} ! {guessesLeft} essai(s) restants !");
            guessesLeft--;
        }
        if (nbr == nbrGuess)
        {
            Console.WriteLine($"Pas besoin de chercher plus loin, {nbr} est la bonne réponse !");
        }
        if (guessesLeft == 0)
        {
            Console.WriteLine($"Perdu ! La réponse était {nbr} !");
        }
    }
}
if (mode == "moyen")
{
    Console.WriteLine($"C'est parti pour le mode {mode} ! Veuillez entrer un nombre de 1 à 100.");
    int nbr = new Random().Next(0, 100);
    int guessesLeft = 4;

    while (guessesLeft > 0)
    {
        int nbrGuess = int.Parse(Console.ReadLine());

        if (nbr > nbrGuess)
        {
            Console.WriteLine($"Le nombre recherché est supérieur à {nbrGuess} ! {guessesLeft} essai(s) restants !");
            guessesLeft--;
        }
        if (nbr < nbrGuess)
        {
            Console.WriteLine($"Le nombre recherché est inférieur à {nbrGuess} ! {guessesLeft} essai(s) restants !");
            guessesLeft--;
        }
        if (nbr == nbrGuess)
        {
            Console.WriteLine($"Pas besoin de chercher plus loin, {nbr} est la bonne réponse !");
        }
        if (guessesLeft == 0)
        {
            Console.WriteLine($"Perdu ! La réponse était {nbr} !");
        }
    }
}
if (mode == "difficile")
{
    Console.WriteLine($"C'est parti pour le mode {mode} ! Veuillez entrer un nombre de 1 à 1000.");
    int nbr = new Random().Next(0, 1000);
    int guessesLeft = 4;

    while (guessesLeft > 0)
    {
        int nbrGuess = int.Parse(Console.ReadLine());

        if (nbr > nbrGuess)
        {
            Console.WriteLine($"Le nombre recherché est supérieur à {nbrGuess} ! {guessesLeft} essai(s) restants !");
            guessesLeft--;
        }
        if (nbr < nbrGuess)
        {
            Console.WriteLine($"Le nombre recherché est inférieur à {nbrGuess} ! {guessesLeft} essai(s) restants !");
            guessesLeft--;
        }
        if (nbr == nbrGuess)
        {
            Console.WriteLine($"Pas besoin de chercher plus loin, {nbr} est la bonne réponse !");
        }
        if (guessesLeft == 0)
        {
            Console.WriteLine($"Perdu ! La réponse était {nbr} !");
        }
    }
}