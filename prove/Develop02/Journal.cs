public class Journal 
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    public Journal(string[] importLines)
    {
        entries = new List<Entry>();
        foreach (var line in importLines)
        {
            var entry = new Entry(line);
            entries.Add(entry);
        }
    }

    public void DisplayEntries()
    {   
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.DisplayEntry());
        }
    }

    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var entry in entries)
        {
            exportLines.Add(entry.ExportEntry());
        }
        return exportLines.ToArray();
    }

    public void AddEntry()
    {
        var date = DateTime.Now.ToString();
        Console.WriteLine(date);

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "List three things you accomplished today.",
            "List three things you are grateful for.",
            "What brought you joy today?",
            "What was your favorite thing you did today?",
            "What was your favorite thing you ate today?"
        };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        var prompt = prompts[index];
        Console.WriteLine(prompt);

        var response = Console.ReadLine();

        var entry = new Entry(date, prompt, response);
        entries.Add(entry);
        
    }
}