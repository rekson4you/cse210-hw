using System;
using System.Collections.Generic;

class Program
{
    static void ClearConsole()
    {
        Console.Clear();
    }

    static void Main(string[] args)
    {
        // Create a list of different scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.."),
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Philippians", 4, 13),
                " I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Psalm", 23, 1, 2),
                "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters."),
        };

        // Randomly select a scripture to display
        Random random = new Random(); 
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            ClearConsole();
            Console.WriteLine(selectedScripture.GetDisplayText());
            if (selectedScripture.AllWordsHidden())
            {
                break;
            }
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "Quit")
            {
                break;
            }
            selectedScripture.HideRandomWords(3);
        }
    }
}
