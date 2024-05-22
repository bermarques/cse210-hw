using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Activity Tracker!");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listening");
            Console.WriteLine("4. Laughter");
            Console.WriteLine("5. Exit");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.DisplayStartingMessaging();
                    breathing.Run();
                    breathing.DisplayEndingMessage();
                    break;
                case "2":
                    ReflectingActivity reflextion = new ReflectingActivity();
                    reflextion.DisplayStartingMessaging();
                    reflextion.Run();
                    reflextion.DisplayEndingMessage();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.DisplayStartingMessaging();
                    listing.Run();
                    listing.DisplayEndingMessage();
                    break;
                // case "4":
                //     LaughterActivity laughter = new LaughterActivity();
                //     laughter.DisplayStartingMessage();
                //     laughter.Run();
                //     laughter.DisplayEndingMessage();
                //     break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter a valid input.");
                    break;
            }
        }
    }
}