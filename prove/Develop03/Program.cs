class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Helaman", 5, 12, 12, "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

        Console.Clear();
        scripture.DisplayScripture();

        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        string input = Console.ReadLine();

        while (scripture.HasHiddenWords() && input.ToLower() != "quit")
        {
            scripture.HideRandomWords(3);
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine();

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            input = Console.ReadLine();
        }
        
    }
}