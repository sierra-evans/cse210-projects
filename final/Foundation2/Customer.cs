public class Customer
{
    private string name;
    Address address;

    public Customer(string name)
    {
        this.name = name;
        address = GetAddress();
    }

    public Address GetAddress()
    {
        address = new Address("18612 N. Peachtree Blvd.", "Queen Creek", "AZ", "USA");
        return address;
    }

    public bool IsInUSA()
    {
        if (address.InUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayName()
    {
        Console.WriteLine($"{name}");
    }

    public string ShippingLabelName()
    {
        return $"{name}";
    }

    public string CustomerShippingLabelAddress()
    {
        return address.ShippingLabelAddress();
    }
}