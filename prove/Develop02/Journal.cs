using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me smile today?",
        "What challenge did I overcome today?",
        "What did I learn today?",
        "What am I grateful for today?",
        "How did I help someone today?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();

        entries.Add(new Entry(prompt, response, date));
        Console.WriteLine("Entry added successfully.");
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToCSV(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                string sanitizedResponse = entry.Response.Replace("\"", "\"\""); 
                writer.WriteLine($"\"{entry.Date}\",\"{entry.Prompt}\",\"{sanitizedResponse}\"");
            }
        }
        Console.WriteLine("Journal saved as CSV successfully.");
    }

    public void LoadFromCSV(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split("\",\"");

                if (parts.Length == 3)
                {
                    string date = parts[0].Trim('"');
                    string prompt = parts[1].Trim('"');
                    string response = parts[2].Trim('"');
                    entries.Add(new Entry(prompt, response, date));
                }
            }
            Console.WriteLine("Journal loaded from CSV successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void AddCustomPrompt()
    {
        Console.Write("Enter a new prompt: ");
        string newPrompt = Console.ReadLine();
        prompts.Add(newPrompt);
        Console.WriteLine("Custom prompt added successfully.");
    }
}
