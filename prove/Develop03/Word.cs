public class Word {
    public string word;
    public bool isHidden;

    public Word(string word)
    {
        this.word = word;
        isHidden = false;
    }

    // private int countLetters(string word)
    // {
    //     int numLetters = word.Count(char.IsLetter);
    //     return numLetters;
    // }

    public void hideWord()
    {
        isHidden = true;
    }

    
}