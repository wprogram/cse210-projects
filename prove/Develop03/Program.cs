using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        Scripture scripture = scriptureLibrary.GetRandomScripture();

        while (!scripture.AreAllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.WriteLine("\nAll words are hidden or you quit the program. Goodbye!");
    }
}
