using System;

class Program
{
    static void Main(string[] args)
    {
        // Defining the variables
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        string userGuessInText;
        int userGuess;

        do
        {
            Console.Write("What is your guess? ");
            userGuessInText = Console.ReadLine();
            userGuess = int.Parse(userGuessInText);

            if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("Lower");
            }
        } while (magicNumber != userGuess);

        Console.WriteLine("You guessed it!");
        
    }
}