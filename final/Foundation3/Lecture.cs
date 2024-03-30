public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, string date, string time, string type, string speaker, int capacity) : base(title, description, date, time, type)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override void DisplayFull()
    {
        base.DisplayFull();
        Console.WriteLine($"Speaker: {speaker}\nCapacity: {capacity}");
    }
}