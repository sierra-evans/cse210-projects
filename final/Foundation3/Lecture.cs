public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, string date, string time, Address address, string type, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFull()
    {
        return base.GetFull();
    }
}