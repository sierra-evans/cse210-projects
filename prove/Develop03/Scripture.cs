using System.ComponentModel.DataAnnotations;

public class Scripture {
    private Reference reference;
    private List<Word> words;

    public Scripture(string referenceText, string scriptureText)
    {
        reference = new Reference(referenceText);
        words = new List<Word>();

        string[] wordList = scriptureText.Split(' ');

        foreach (string word in wordList)
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

    public void DisplayScripture()
    {
        Console.WriteLine(reference.GetReference());
        foreach (Word word in words)
        {
            Console.Write(word.IsHidden ? "___ " : word.Text + " ");
            // if (word.IsHidden == true)
            // {
            //     Console.WriteLine("___ ");
            // }
            // else 
            // {
            //     Console.WriteLine(word.Text + " ");
            // }
        }
    }

    public void HideRandomWords(int numberOfWords)
    {
        Random random = new Random();

        // Get all the words that are not already hidden
        List<Word> availableWords = words.Where(word => !word.IsHidden).ToList();

        // Hide a specified number of random words
        int wordsToHideCount = Math.Min(numberOfWords, availableWords.Count);
        for (int i = 0; i < wordsToHideCount; i++)
        {
            int index = random.Next(0, availableWords.Count);
            availableWords[index].Hide();
            availableWords.RemoveAt(index);
        }
    }

    public bool HasHiddenWords()
    {
        return words.Any(word => !word.IsHidden);
    }

    // private string chooseRandomWord(List<string> words)
    // {
    //     int length = words.Count;
    //     int numWords = length - 1;
    //     Random r = new Random();
    //     int randomIndex = r.Next(0, numWords);
    //     string randomWord = words[randomIndex];
    //     return randomWord;
    // }

    // public string createScripture()
    // {
        
    // }
}