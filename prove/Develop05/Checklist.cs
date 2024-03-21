public class Checklist : Goal
{
    private int bonusPoints;

    public Checklist() : base()
    {
        bonusPoints = GetBonusPoints();
    }

    public Checklist(string values) : base(values.Split($"{Goal.DELIMITER}{Goal.DELIMITER}")[0])
    {
        var goalValues = values.Split($"{Goal.DELIMITER}{Goal.DELIMITER}")[1].Split(Goal.DELIMITER);
        bonusPoints = int.Parse(goalValues[0]);
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
        Console.Write($", Completion: {timesCompleted}/{completionNumber}, Bonus Points: {bonusPoints}");
    }

    public override string Export()
    {
        return "C:" + base.Export() + $"{DELIMITER}{DELIMITER}{timesCompleted}/{completionNumber}{DELIMITER}{bonusPoints}";
    }

    public override void PerformTask()
    {

    }
}