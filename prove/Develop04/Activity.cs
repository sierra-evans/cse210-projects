class Activity {
    protected string name;
	protected string description;

	public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

	public int GetDuration()
    {
        Console.WriteLine("Please enter the amount of time in seconds you would like to participate in this activity:");
        int duration = Int32.Parse(Console.ReadLine());
        return duration;
    }

	public bool CheckTime(DateTime endTime)
    {
        bool activityComplete;
        DateTime currentTime = DateTime.Now;

        if (currentTime < endTime)
        {
            activityComplete = false;
        }
        else
        {
            activityComplete = true;
        }
        return activityComplete;
    }

    public int GetSeconds(DateTime startTime)
    {
        DateTime currentTime = DateTime.Now;
        double seconds = System.Math.Abs((currentTime - startTime).TotalSeconds);
        int roundedSeconds = Convert.ToInt32(seconds);
        return roundedSeconds;
    }

    public void Prepare()
    {
        Console.WriteLine("Please prepare to begin, the activity will start in just a moment...");
        DisplayAnimation();
    }

	public void DisplayStartMessage(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name} activity! \n{description}");
    }

	public void DisplayEndMessage(int roundedSeconds, string name)
    {
        Console.WriteLine($"Well done! \nYou have completed {roundedSeconds} seconds of the {name} activity! \nReturning to menu...");
    }
    public void DisplayWaitMessage()
    {
        Console.WriteLine("The activity will begin in a moment, please prepare...");
        DisplayAnimation();
    }
	public void DisplayAnimation()
    {
        Console.Write("\\");

        Thread.Sleep(500);

        Console.Write("\b \b"); 
        Console.Write("-"); 

        Thread.Sleep(500);

        Console.Write("\b \b"); 
        Console.Write("/");

        Thread.Sleep(500);

        Console.Write("\b \b"); 
        Console.Write("\\"); 
        
        Thread.Sleep(500);

        Console.Write("\b \b"); 
        Console.Write("-");

        Thread.Sleep(500);

        Console.Write("\b \b"); 
        Console.Write("/"); 

        Thread.Sleep(500);

        Console.Write("\b \b"); 
    }

}