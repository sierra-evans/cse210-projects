public class Simple : Goal
{
    public Simple() : base()
    {

    }

    public Simple(string values) : base(values)
    {

    }

    public override void Display()
    {
        base.Display();
    }

    public override string Export()
    {
        return "S:" + base.Export();
    }

    public override void PerformTask()
    {

    }
}