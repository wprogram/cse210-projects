// Additional Exceeding Requirements Implemented: CSV Handling Enhancements - I properly handle quotes in responses to make sure they are compatible with CSV formatting. Custom Prompt Feature - I allow the user to add custom prompts to the list, making the journal experience more personalized.
using System;

static class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        bool running = true;

        Console.WriteLine("Welcome back! Don't forget to write in your journal today.");

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a CSV file");
            Console.WriteLine("4. Load the journal from a CSV file");
            Console.WriteLine("5. Add a custom prompt");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to save as CSV: ");
                    string csvSaveFilename = Console.ReadLine();
                    journal.SaveToCSV(csvSaveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load from CSV: ");
                    string csvLoadFilename = Console.ReadLine();
                    journal.LoadFromCSV(csvLoadFilename);
                    break;
                case "5":
                    journal.AddCustomPrompt();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
