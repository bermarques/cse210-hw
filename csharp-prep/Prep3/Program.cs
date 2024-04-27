using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int answer;
        int number = randomGenerator.Next(1, 100);
        int guesses = 0;

        do
        {
            Console.WriteLine("What is your guess?");
            answer = int.Parse(Console.ReadLine());
            guesses += 1;

            if (number > answer)
            {
                Console.WriteLine("Higher");
            }
            else if (number < answer)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you{guesses} guesses!");
            }
        } while (answer != number);
    }
}