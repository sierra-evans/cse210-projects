public class Eternal : Goal 
{
    public Eternal() : base()
    {

    }

    public Eternal(string values) : base(values)
    {
        var goalValues = values.Split(DELIMITER);
        isComplete = goalValues[0];
        name = goalValues[1];
        description = goalValues[2];
        points = int.Parse(goalValues[3]);
        timesCompleted = int.Parse(goalValues[4]);
        completionNumber = int.Parse(goalValues[5]);
    }

    public override int GetCompletionNumber()
    {
        int completionNumber = 400000000;
        return completionNumber;
    }

    public override void Display()
    {
        base.Display();
        Console.Write($", Times Completed: {timesCompleted}");
    }

    public override string Export()
    {
        return "E:" + base.Export();
    }

    // public override void PerformTask()
    // {

    // }
}

// TEST CODE

// public class Eternal : Goal 
// {
//     public Eternal() : base()
//     {
//         // Constructor for creating a new eternal goal
//     }

//     public Eternal(string values) : base(values)
//     {
//         // Constructor for loading an eternal goal from a string
//     }

//     // Override Display method to include the type of goal
//     public override void Display()
//     {
//         Console.Write("[Eternal] ");
//         base.Display();
//     }

//     // Override Export method to include the type identifier
//     public override string Export()
//     {
//         return "E:" + base.Export();
//     }

//     // Override GetCompletionNumber method for eternal goals
//     public override int GetCompletionNumber()
//     {
//         return int.MaxValue; // Eternal goals have no completion limit
//     }
// }
