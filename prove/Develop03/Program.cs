//Handles user interaction, drives the program flow, and coordinates between other classes.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Display scripture options from the Scripture class
        Console.WriteLine("Select a scripture to memorize:");
        var scriptures = Scripture.GetAllScriptures();
        int i = 1;
        foreach (var scripture in scriptures)
        {
            Console.WriteLine($"{i}. {scripture.Reference.GetReference()}");
            i++;
        }

        // User selects a scripture
        Console.Write("\nEnter the number of the scripture you'd like to memorize: ");
        if (!int.TryParse(Console.ReadLine(), out int selection) || selection < 1 || selection > scriptures.Count)
        {
            Console.WriteLine("Invalid selection. Exiting program.");
            return;
        }

        // Retrieve the selected scripture
        var selectedScripture = scriptures[selection - 1];
        WordHider wordHider = new WordHider(selectedScripture);

        // Memorization process
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());

            if (selectedScripture.IsFullyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            wordHider.HideRandomWords();
        }
    }
}