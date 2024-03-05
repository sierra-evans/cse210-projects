class Activity {
    protected string name;
	protected string description;
	// protected int duration;
	// protected DateTime startTime;
	// protected DateTime endTime;

	public Activity(string name, string description) //int duration, DateTime startTime, DateTime endTime)
    {
        this.name = name;
        this.description = description;
        // this.duration = duration;
        // this.startTime = startTime;
        // this.endTime = endTime;
    }

	public int GetDuration()
    {
        Console.WriteLine("Please enter the amount of time in seconds you would like to participate in this activity:");
        duration = Int32.Parse(Console.ReadLine());
        return duration;
    }
	public bool CheckTime( DateTime endTime)
    {
        DateTime currentTime = DateTime.Now;
        // DateTime endTime = currentTime.AddSeconds(duration);
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
    public int GetSeconds(startTime)
    {
        DateTime currentTime = DateTime.Now;
        int seconds = System.Math.Abs((currentTime - startTime).TotalSeconds);
        return seconds;
    }
    public void Prepare()
    {
        Console.WriteLine("Please prepare to begin, the activity will start in just a moment...")
        DisplayAnimation();
    }
	public string DisplayStartMessage(string name, string description)
    {
        return $"Welcome to the {name} activity! \n{desciption}"
    }
	public string DisplayEndMessage()
    {
        return $"Well done! \nYou have completed {seconds} of the {name} activity! \nReturning to menu..."
    }
	public void DisplayAnimation()
    {
        Console.Write("\\");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character

        Thread.Sleep(500);

        Console.Write("\b \b"); 
        Console.Write("/");
    }

}