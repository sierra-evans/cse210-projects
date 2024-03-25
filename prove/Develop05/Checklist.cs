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