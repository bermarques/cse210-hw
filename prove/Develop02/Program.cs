using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int selectedOption = 0;
        Journal journal = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do");
            selectedOption = int.Parse(Console.ReadLine());

            if (selectedOption == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                string answer = Console.ReadLine();

                journal.AddEntry(new Entry { _date = dateText, _entryText = answer, _promptText = prompt });
            }
            else if (selectedOption == 2)
            {
                journal.DisplayAll();
            }
            else if (selectedOption == 3)
            {

                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }
            else if (selectedOption == 4)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
        } while (selectedOption != 5);
    }
}