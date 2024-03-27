using System.Net.Sockets;

public class Event
{
    protected string title;
	protected string description;
	protected string date;
	protected string time;
	Address address;
	protected string type;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
        this.type = type;
    }

    public string GetStandard()
    {

    }

    public string GetShort()
    {

    }

    public virtual string GetFull()
    {

    }
}