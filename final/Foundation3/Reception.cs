public class Reception : Event
{
    private string email;

    public Reception(string title, string description, string date, string time, string type, string email) : base(title, description, date, time, type)
    {
        this.email = email;
    }

    public override Address GetAddress()
    {
        Address address = new Address("1160 W. Drury Ln.", "Los Angeles", "CA", "USA");
        return address;
    }

    public override void DisplayFull()
    {
        base.DisplayFull();
        Console.WriteLine($"RSVP: {email}");
    }
}