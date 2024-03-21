using System.ComponentModel.DataAnnotations;

class Listing : Activity {
    private List<string> prompts;

    public Listing(string name, string description, List<string> prompts) : base(name, description)
    {
        this.prompts = prompts;
    }

    public void ListingExercise()
    {
        Console.WriteLine();
        DisplayStartMessage(name, description);
        Console.WriteLine();

        int duration = GetDuration();
        List<string> responses = [];

        Console.WriteLine();
        DisplayWaitMessage();
        Console.WriteLine();

        string prompt = GetRandomPrompt(prompts);

        bool activityComplete = false;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt(prompt);
        DisplayAnimation();
        while (activityComplete != true)
        {
            Console.Write(">");
            responses.Add(Console.ReadLine());
            activityComplete = CheckTime(endTime);
        }
        int roundedSeconds = GetSeconds(startTime);
        int numItems = GetNumItems(responses);
        DisplayNumItems(numItems);
        DisplayEndMessage(roundedSeconds, name);
        DisplayAnimation();
        DisplayAnimation();
    }

    public string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        
        int index = random.Next(0, prompts.Count);
        string prompt = prompts[index];
        return prompt;
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Consider the following prompt:\n---{prompt}---");
    }

    public int GetNumItems(List<string> responses)
    {
        int numItems = responses.Count();
        return numItems;
    }

    public void DisplayNumItems(int numItems)
    {
        Console.WriteLine($"You listed {numItems} items!");
    }
}