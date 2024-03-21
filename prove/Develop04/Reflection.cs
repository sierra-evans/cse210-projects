class Reflection : Activity {
    private List<string> prompts;
	private List<string> questions;

	public Reflection(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        this.prompts = prompts;
        this.questions = questions;
    }
	public void ReflectionExercise()
    {
        Console.WriteLine();
        DisplayStartMessage(name, description);
        Console.WriteLine();

        int duration = GetDuration();

        Console.WriteLine();
        DisplayWaitMessage();
        Console.WriteLine();

        string prompt = GetRandomPrompt(prompts);

        DisplayPrompt(prompt);
        Console.WriteLine("Press enter when you have something in mind.");

        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            bool activityComplete = false;
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);
            Console.WriteLine("Ponder these questions:");
            Console.WriteLine();
            while (activityComplete != true)
            {
                string question = GetRandomQuestion(questions);
                DisplayQuestion(question);
                DisplayAnimation();
                DisplayAnimation();
                activityComplete = CheckTime(endTime);
            }
            int roundedSeconds = GetSeconds(startTime);
            DisplayEndMessage(roundedSeconds, name);
            DisplayAnimation();
            DisplayAnimation();
        }
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

	public string GetRandomQuestion(List<string> questions)
    {
        Random random = new Random();
        
        int index = random.Next(0, questions.Count);
        string question = questions[index];
        return question;
    }

    public void DisplayQuestion(string question)
    {
        Console.WriteLine($"{question}");
    }
}