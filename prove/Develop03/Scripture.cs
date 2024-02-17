using System.ComponentModel.DataAnnotations;

public class Scripture {
    private Reference reference;
    private List<Word> words;

    public Scripture(string referenceText, string scriptureText)
    {
        reference = new Reference(referenceText);
        words = new List<Word>();

        string[] words = scriptureText.Split(' ');

        foreach (string word in words)
        {
            words.Add(new Word(word));
        }
        
        // string book = "Helaman";
        // int chapter = 5;
        // int verseStart = 12;
        // int verseEnd = 12;
        // Reference reference = new Reference(book, chapter, verseStart, verseEnd);
        // reference = reference.convertToString(verseStart, verseEnd);
        // reference = reference.ExportReference();
        // words = convertToList(text);

    }

    // private List<string> convertToList(string text)
    // {
    //     text = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";
    //     List<string> words = text.Split(' ').ToList();
    //     return words;
    // }

    public void DisplayScripture()
    {
        
    }

    private string chooseRandomWord(List<string> words)
    {
        int length = words.Count;
        int numWords = length - 1;
        Random r = new Random();
        int randomIndex = r.Next(0, numWords);
        string randomWord = words[randomIndex];
        return randomWord;
    }

    public string createScripture()
    {
        
    }
}