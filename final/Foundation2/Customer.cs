using System.ComponentModel;

public class Customer
{
    private string name;
    Address address;
    private int customerIdentifier;

    public Customer(string name, int customerIdentifier)
    {
        this.name = name;
        this.customerIdentifier = customerIdentifier;
        address = GetAddress();
    }

    public Address GetAddress()
    {
        if (customerIdentifier == 1)
        {
            address = new Address("18612 N. Peachtree Blvd.", "Queen Creek", "AZ", "USA");
            return address;
        }
        else if (customerIdentifier == 2)
        {
            address = new Address("18612 N. Peachtree Blvd.", "Queen Creek", "AZ", "Canada");
            return address;
        }
        else
        {
            return null;
        }
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