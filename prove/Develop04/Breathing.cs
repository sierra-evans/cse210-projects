class Breathing : Activity {
    public Breathing(string name, string description) : base(name, description)
    {
    
    }
	public void BreathingExercise()
    {
        Console.WriteLine();
        DisplayStartMessage(name, description);
        Console.WriteLine();

        int duration = GetDuration();
        
        Console.WriteLine();
        DisplayWaitMessage();
        Console.WriteLine();

        bool activityComplete = false;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (activityComplete != true)
        {
            DisplayBreathing();
            Console.WriteLine();
            activityComplete = CheckTime(endTime);
        }
        int roundedSeconds = GetSeconds(startTime);
        Console.WriteLine();
        DisplayEndMessage(roundedSeconds, name);
        DisplayAnimation();
        DisplayAnimation();
    }
    
    public void DisplayBreathing()
    {
        Console.Write("Breathe in...");
        DisplayAnimation();
        Console.WriteLine();
        Console.Write("Breathe out...");
        DisplayAnimation();
        Console.WriteLine();
    }
}