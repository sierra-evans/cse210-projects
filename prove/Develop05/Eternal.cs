public class Eternal : Goal 
{
    public Eternal() : base()
    {

    }

    public Eternal(string values) : base(values)
    {
        var goalValues = values.Split(DELIMITER);
        name = goalValues[0];
        description = goalValues[1];
        points = int.Parse(goalValues[2]);
    }

    public override int GetCompletionNumber()
    {
        int completionNumber = 400000000;
        return completionNumber;
    }

    public override void Display()
    {
        base.Display();
    }

    public override string Export()
    {
        return "E:" + base.Export();
    }

    public override void PerformTask()
    {

    }
}