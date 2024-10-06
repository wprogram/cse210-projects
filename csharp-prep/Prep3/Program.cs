using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine($"The magic number is: {magicNumber}");

        int guess = -1; 
        int guessCount = 0;

        Console.WriteLine("I have picked a magic number between 1 and 100. Try to guess it!");

        while (guess != magicNumber)
        {
        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        guess = int.Parse(guessInput);
        guessCount++;

        if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
        }
    }
        Console.Write("Do you want to play again? (yes/no): ");
        playAgain = Console.ReadLine();
    }
     Console.WriteLine("Thanks for playing!");
    }
}