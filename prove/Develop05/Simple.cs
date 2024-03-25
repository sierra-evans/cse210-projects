public class Simple : Goal
{
    public Simple() : base()
    {

    }

    public Simple(string values) : base(values)
    {
        var goalValues = values.Split(DELIMITER);
        isComplete = goalValues[0];
        name = goalValues[1];
        description = goalValues[2];
        points = int.Parse(goalValues[3]);
        timesCompleted = int.Parse(goalValues[4]);
        completionNumber = int.Parse(goalValues[5]);
    }

    public override void Display()
    {
        base.Display();
        Console.Write($", Progress: {timesCompleted}/{completionNumber}");
    }

    public override string Export()
    {
        return "S:" + base.Export();
    }

    // public override void PerformTask()
    // {

    // }
}

// TEST CODE

// public class Simple : Goal
// {
//     public Simple() : base()
//     {
//         // Constructor for creating a new simple goal
//     }

//     public Simple(string values) : base(values)
//     {
//         // Constructor for loading a simple goal from a string
//     }

//     // Override Display method to include the type of goal
//     public override void Display()
//     {
//         Console.Write("[Simple] ");
//         base.Display();
//     }

//     // Override Export method to include the type identifier
//     public override string Export()
//     {
//         return "S:" + base.Export();
//     }
// }
