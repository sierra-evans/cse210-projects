public class Outdoor : Event
{
    private string weather;

    public Outdoor(string title, string description, string date, string time, Address address, string type, string weather) : base(title, description, date, time, address, type)
    {
        this.weather = weather;
    }

    public override string GetFull()
    {
        return base.GetFull();
    }
}