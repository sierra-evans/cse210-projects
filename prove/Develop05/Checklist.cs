public class Checklist : Goal
{
    private int bonusPoints;

    public Checklist() : base()
    {
        bonusPoints = GetBonusPoints();
    }

    public Checklist(string values) : base(values.Split($"{Goal.DELIMITER}{Goal.DELIMITER}")[0])
    {
        var goalValues = values.Split(DELIMITER);
        isComplete = goalValues[0];
        name = goalValues[1];
        description = goalValues[2];
        points = int.Parse(goalValues[3]);
        timesCompleted = int.Parse(goalValues[4]);
        completionNumber = int.Parse(goalValues[5]);
        bonusPoints = int.Parse(goalValues[6]);
    }

    public override int GetCompletionNumber()
    {
        Console.WriteLine("Enter how many times this goal needs to be met to be complete:");
        int completionNumber = int.Parse(Console.ReadLine());
        return completionNumber;
    }

    public int GetBonusPoints()
    {
        Console.WriteLine("Enter the amount of bonus points to be awarded one goal is met:");
        int bonusPoints = int.Parse(Console.ReadLine());
        return bonusPoints;
    }

    public override void Display()
    {
        base.Display();
        Console.Write($", Progress: {timesCompleted}/{completionNumber}, Bonus Points: {bonusPoints}");
    }

    public override string Export()
    {
        return "C:" + base.Export() + $"{DELIMITER}{bonusPoints}";
    }

    public override int RecordEvent(int totalPoints)
    {
        timesCompleted += 1;
        totalPoints += points;
        Console.WriteLine("Event recorded successfully!");
        isComplete = IsComplete();
        if (isComplete == "[x]")
        {
            totalPoints += bonusPoints;
            Console.WriteLine("Congratulations! Goal completed!");
        }
        return totalPoints;
    }
}

// TEST CODE

// public class Checklist : Goal
// {
//     private int bonusPoints;

//     public Checklist() : base()
//     {
//         bonusPoints = GetBonusPoints();
//     }

//     public Checklist(string values) : base(values)
//     {
//         var goalValues = values.Split($"{DELIMITER}{DELIMITER}")[0].Split(DELIMITER);
//         bonusPoints = int.Parse(goalValues[5]);
//     }

//     // Override GetCompletionNumber method for checklist goals
//     public override int GetCompletionNumber()
//     {
//         Console.WriteLine("Enter how many times this goal needs to be met to be complete:");
//         int completionNumber = int.Parse(Console.ReadLine());
//         return completionNumber;
//     }

//     // Method to get bonus points for checklist goals
//     public int GetBonusPoints()
//     {
//         Console.WriteLine("Enter the amount of bonus points to be awarded once the goal is met:");
//         int bonusPoints = int.Parse(Console.ReadLine());
//         return bonusPoints;
//     }

//     // Override Display method to include the type of goal and bonus points
//     public override void Display()
//     {
//         Console.Write("[Checklist] ");
//         base.Display();
//         Console.WriteLine($", Bonus Points: {bonusPoints}");
//     }

//     // Override Export method to include the type identifier and bonus points
//     public override string Export()
//     {
//         return "C:" + base.Export() + $"{DELIMITER}{DELIMITER}{bonusPoints}";
//     }
// }
