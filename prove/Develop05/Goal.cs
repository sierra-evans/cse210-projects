public class Goal 
{
    public static readonly string DELIMITER = "|";

    protected int points;
    protected string name;
    protected string description;
    protected int completionNumber;
    protected int timesCompleted;
    protected string isComplete;

    public Goal()
    {
        name = GetName();
        description = GetDescription();
        points = GetPoints();
        completionNumber = GetCompletionNumber();
        timesCompleted = 0;
        isComplete = IsComplete();
    }

    public Goal(string values)
    {
        var goalValues = values.Split(DELIMITER);
        isComplete = goalValues[0];
        name = goalValues[1];
        description = goalValues[2];
        points = int.Parse(goalValues[3]);
        timesCompleted = int.Parse(goalValues[4]);
        completionNumber = int.Parse(goalValues[5]);
    }

    public int GetPoints()
    {
        Console.WriteLine("Enter the amount of points the goal is worth:");
        int points = int.Parse(Console.ReadLine());
        return points;
    }

    public string GetName()
    {
        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();
        return name;
    }

    public string GetDescription()
    {
        Console.WriteLine("Enter the description of the goal:");
        string description = Console.ReadLine();
        return description;
    }

    public virtual int GetCompletionNumber()
    {
        int completionNumber = 1;
        return completionNumber;
    }

    public virtual int RecordEvent(int totalPoints)
    {
        timesCompleted += 1;
        totalPoints += points;
        Console.WriteLine("Event recorded successfully!");
        isComplete = IsComplete();
        if (isComplete == "[x]")
        {
            Console.WriteLine("Congratulations! Goal completed!");
        }
        return totalPoints;
    }

    // public void DisplayGoals()
    // {

    // }

    // public void DisplayScore()
    // {

    // }

    public string IsComplete()
    {
        if (timesCompleted >= completionNumber)
        {
            string isComplete = "[x]";
            return isComplete;
        }

        else
        {
            string isComplete = "[ ]";
            return isComplete;
        }
    }

    public virtual void Display()
    {
        Console.WriteLine($"{isComplete} Name: {name}, Description: {description}, Points: {points}");
    }

    public virtual string Export()
    {
        return $"{isComplete}{DELIMITER}{name}{DELIMITER}{description}{DELIMITER}{points}{DELIMITER}{timesCompleted}{DELIMITER}{completionNumber}";
    }

    // public virtual void PerformTask()
    // {
    //     timesCompleted += 1;
    //     IsComplete();
    // }
}

// TEST CODE

// public abstract class Goal
// {
//     public static readonly string DELIMITER = "|";

//     protected int points;
//     protected string name;
//     protected string description;
//     protected int completionNumber;
//     protected int timesCompleted;

//     public Goal()
//     {
//         name = GetName();
//         description = GetDescription();
//         points = GetPoints();
//         completionNumber = GetCompletionNumber();
//         timesCompleted = 0;
//     }

//     public Goal(string values)
//     {
//         var goalValues = values.Split(DELIMITER);
//         name = goalValues[0];
//         description = goalValues[1];
//         points = int.Parse(goalValues[2]);
//         timesCompleted = int.Parse(goalValues[3]);
//         completionNumber = int.Parse(goalValues[4]);
//     }

//     public int GetPoints()
//     {
//         Console.WriteLine("Enter the amount of points the goal is worth:");
//         int points = int.Parse(Console.ReadLine());
//         return points;
//     }

//     public string GetName()
//     {
//         Console.WriteLine("Enter the name of the goal:");
//         string name = Console.ReadLine();
//         return name;
//     }

//     public string GetDescription()
//     {
//         Console.WriteLine("Enter the description of the goal:");
//         string description = Console.ReadLine();
//         return description;
//     }

//     public virtual int GetCompletionNumber()
//     {
//         Console.WriteLine("Enter the completion number of the goal:");
//         int completionNumber = int.Parse(Console.ReadLine());
//         return completionNumber;
//     }

//     public void RecordEvent()
//     {
//         timesCompleted++;
//         Console.WriteLine("Event recorded successfully!");
//         if (IsComplete())
//         {
//             Console.WriteLine("Congratulations! Goal completed!");
//         }
//     }

//     public virtual void Display()
//     {
//         Console.WriteLine($"Name: {name}, Description: {description}, Points: {points}, Completed: {timesCompleted}/{completionNumber}");
//     }

//     public virtual string Export()
//     {
//         return $"{name}{DELIMITER}{description}{DELIMITER}{points}{DELIMITER}{timesCompleted}{DELIMITER}{completionNumber}";
//     }

//     public bool IsComplete()
//     {
//         return timesCompleted >= completionNumber;
//     }
// }
