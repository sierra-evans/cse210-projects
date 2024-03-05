class Breathing : Activity {
    public Breathing(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
	public int BreathingExercise()
    {
        base.DisplayStartMessage(name, description);

        duration = base.GetDuration();

        bool activityComplete;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        while (activityComplete != true)
        {

            activityComplete = base.CheckTime();
        }
        seconds = base.GetSeconds(startTime);



    }
    
    public void DisplayBreathing()
    {
        Console.WriteLine("Breathe in...")
        Console.WriteLine("Breathe out...")
    }



}