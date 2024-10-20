public class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int verseEnd;

    // Constructor for a single verse reference
    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verse;
        this.verseEnd = verse;
    }

    // Constructor for a verse range reference
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    // Method to get the reference as a string
    public string GetReference()
    {
        if (verseStart == verseEnd)
        {
            return $"{book} {chapter}:{verseStart}";
        }
        else
        {
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
    }
}
