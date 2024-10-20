using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    // Constructor to initialize the scripture with a reference and text
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    // Method to get the scripture text with hidden words
    public string GetRenderedText()
    {
        string renderedText = "";
        foreach (Word word in words)
        {
            renderedText += word.IsHidden() ? "____ " : word.GetText() + " ";
        }
        return $"{reference.GetReference()} {renderedText.Trim()}";
    }

    // Method to hide a few random words in the scripture
    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, 4); // Hide 1 to 3 words at a time
        for (int i = 0; i < wordsToHide; i++)
        {
            List<Word> visibleWords = words.FindAll(word => !word.IsHidden());
            if (visibleWords.Count > 0)
            {
                int index = random.Next(0, visibleWords.Count);
                visibleWords[index].Hide();
            }
        }
    }

    // Method to check if all words are hidden
    public bool AreAllWordsHidden()
    {
        return words.TrueForAll(word => word.IsHidden());
    }
}
