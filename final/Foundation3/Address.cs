using System.Collections.Concurrent;

public class Address
{
    private string streetAddress;
	private string city;
	private string stateOrProvince;
	private string country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{streetAddress}");
        Console.WriteLine($"{city}, {stateOrProvince}");
        Console.WriteLine($"{country}");
    }
}