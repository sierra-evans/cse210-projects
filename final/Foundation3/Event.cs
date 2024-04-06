using System.Net.Sockets;

public class Event
{
    protected string title;
	protected string description;
	protected string date;
	protected string time;
	Address address;
	protected string type;

    public Event(string title, string description, string date, string time, string type)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        address = GetAddress();
        this.type = type;
    }

    public virtual Address GetAddress()
    {
        Address address = new Address("4430 N. Peachtree Blvd.", "Queen Creek", "AZ", "USA");
        return address;
    }

    public void DisplayStandard()
    {

        Console.WriteLine($"Title : {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress:\n{address.GetDisplayAddress()}");
    }

    public void DisplayShort()
    {
        Console.WriteLine($"Event Type: {type}\nTitle: {title}\nDate: {date}");
    }

    public virtual void DisplayFull()
    {
        Console.WriteLine($"Event Type: {type}\nTitle : {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress:\n{address.GetDisplayAddress()}");
    }
}