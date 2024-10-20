using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> scriptures; // List to store multiple scriptures

    // Constructor to initialize the list of scriptures
    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.")
        };
    }

    // Method to get a random scripture from the list
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(0, scriptures.Count);
        return scriptures[index];
    }
}
