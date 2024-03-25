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
}
