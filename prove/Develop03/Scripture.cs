using System.ComponentModel.DataAnnotations;

public class Scripture {
    private Reference reference;
    private List<Word> words;

    public Scripture(string book, int chapter, int verseStart, int verseEnd, string scriptureText)
    {
        reference = new Reference(book, chapter, verseStart, verseEnd);
        words = new List<Word>();

        string[] wordList = scriptureText.Split(' ');

        foreach (string word in wordList)
        {
            words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(reference.GetReference());
        foreach (Word word in words)
        {
            if (word.IsHidden == true)
            {
                int wordLength = word.Text.Length;
                for (int i = 0; i < wordLength; i++)
                {
                    Console.Write("_");
                }
                Console.Write(" "); 
            }
            else 
            {
                Console.Write(word.Text + " ");
            }
        }
    }

    public void HideRandomWords(int numberOfWords)
    {
        Random random = new Random();

        List<Word> availableWords = words.Where(word => !word.IsHidden).ToList();

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
}