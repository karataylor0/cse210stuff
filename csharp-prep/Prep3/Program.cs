using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is your magic number?");
        //int number = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int guess = 0;
        int guessCount = 0;

        while (guess != number)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            guessCount ++ ; 
        }
        Console.WriteLine("You win!");
        Console.WriteLine($"You got it in {guessCount} guesses.");
    }
}