public class Reference {
    private string referenceText;
    // private string book;
    // private int chapter;
    // private int verseStart;
    // private int verseEnd;

    public Reference(string referenceText)
    {
        this.referenceText = referenceText;
    }

    public string GetReference()
    {
        return referenceText;
    }
    // private string book;
    // private int chapter;
    // private int verseStart;
    // private int verseEnd;

    // public Reference(string book, int chapter, int verseStart, int verseEnd)
    // {
    //     book = "Helaman";
    //     chapter = 5;
    //     verseStart = 12;
    //     verseEnd = 12;
    // }

    // private string convertToString(int verseStart, int verseEnd)
    // {
    //     string verse = null;
    //     if (verseStart == verseEnd)
    //     {
    //         verse = verseStart.ToString();
    //     }
    //     else 
    //     {
    //         verse = $"{verseStart}-{verseEnd}";
    //     }
    //     return verse;
    // }

    // public string ExportReference(string book, string chapter, string verse)
    // {
    //     return $"{book} {chapter}:{verse}";
    // }
}