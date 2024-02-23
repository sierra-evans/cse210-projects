public class Reference {
    private string book;
    private int chapter;
    private int verseStart;
    private int verseEnd;

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    public string GetReference()
    {
        string verse;
        string reference;
        if (verseStart == verseEnd)
        {
            verse = verseStart.ToString();
        }
        else 
        {
            verse = $"{verseStart}-{verseEnd}";
        }
        reference = $"{book} {chapter}:{verse}";
        return reference;
    }
}