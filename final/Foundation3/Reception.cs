public class Reception : Event
{
    private string email;

    public Reception(string title, string description, string date, string time, Address address, string type, string email) : base(title, description, date, time, address, type)
    {
        this.email = email;
    }

    public override string GetFull()
    {
        return base.GetFull();
    }
}