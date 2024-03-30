public class Outdoor : Event
{
    private string weather;

    public Outdoor(string title, string description, string date, string time, string type, string weather) : base(title, description, date, time, type)
    {
        this.weather = weather;
    }

    public override Address GetAddress()
    {
        Address address = new Address("9950 N. South Blvd.", "Boulder", "CO", "USA");
        return address;
    }

    public override void DisplayFull()
    {
        base.DisplayFull();
        Console.WriteLine($"Weather: {weather}");
    }
}