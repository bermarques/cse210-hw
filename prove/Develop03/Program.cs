using System;

class Program
{

    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        Scripture scripture1 = new Scripture(new Reference("Alma", 37, 37), "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.");
        Scripture scripture2 = new Scripture(new Reference("Mosiah", 28, 20), "And now, as I said unto you, that after king Mosiah had done these things, he took the plates of brass, and all the things which he had kept, and conferred them upon Alma, who was the son of Alma; yea, all the records, and also the interpreters, and conferred them upon him, and commanded him that he should keep and preserve them, and also keep a record of the people, handing them down from one generation to another, even as they had been handed down from the time that Lehi left Jerusalem.");
        Scripture scripture3 = new Scripture(new Reference("Mosiah", 16, 4, 5), "Thus all mankind were lost; and behold, they would have been endlessly lost were it not that God redeemed his people from their lost and fallen state; But remember that he that persists in his own carnal nature, and goes on in the ways of sin and rebellion against God, remaineth in his fallen state and the devil hath all power over him. Therefore he is as though there was no redemption made, being an enemy to God; and also is the devil an enemy to God.");
        scriptures.Add(scripture1);
        scriptures.Add(scripture2);
        scriptures.Add(scripture3);
        Random random = new Random();
        Scripture randomScripture = scriptures[random.Next(1, scriptures.Count)];
        string _userInput;
        do
        {
            Console.WriteLine(randomScripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            _userInput = Console.ReadLine();
            if (_userInput == "" && !randomScripture.IsCompletelyHidden())
            {
                randomScripture.HideRandomWords(3);
                Console.Clear();
            }
            else if (randomScripture.IsCompletelyHidden())
            {
                _userInput = "quit";
            }
        } while (_userInput != "quit");
    }
}