using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string sign = "";
        string letter;

        if (percent % 10 >= 7) {
            sign = "+";
        }
        else if (percent % 10 < 3) {
            sign = "-";
        }

        if (percent >= 90)
        {
            letter = $"A{(sign == "+" ? "" : sign)}";
        }
        else if (percent >= 80)
        {
            letter = $"B{sign}";
        }
        else if (percent >= 70)
        {
            letter = $"C{sign}";
        }
        else if (percent >= 60)
        {
            letter = $"D{sign}";
        }
        else
        {
            letter = "F";
        }

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

        Console.WriteLine($"Your grade is: {letter}");
    }
}