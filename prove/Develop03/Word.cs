public class Word
{
    private string text;
    private bool hidden;

    // Constructor to initialize the word
    public Word(string text)
    {
        this.text = text;
        this.hidden = false;
    }

    // Method to hide the word
    public void Hide()
    {
        hidden = true;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return hidden;
    }

    // Method to get the word text
    public string GetText()
    {
        return text;
    }
}
