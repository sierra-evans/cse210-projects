public class Order
{
    List<Product> products;
    Customer customer;

    public Order()
    {
        products = GetProducts();
        customer = GetCustomer();
    }

    public List<Product> GetProducts()
    {
        
    }

    public Customer GetCustomer()
    {
        customer = new Customer("Sierra");
        return customer;
    }

    public double ComputeTotalCost()
    {
        double totalCost = 0;

        if (customer.IsInUSA())
        {
            int shippingCost = 5;
            totalCost += shippingCost;
        }
        else
        {
            int shippingCost = 35;
            totalCost += shippingCost;
        }

        foreach (var product in products)
        {
            totalCost += product.ComputeProductCost();
        }

        return totalCost;
    }

    public List<string> CreatePackingLabel()
    {
        List<string> packingLabel = new List<string>();

        foreach (var product in products)
        {
            packingLabel.Add(product.PackingLabelProduct());
        }

        return packingLabel;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        List<string> packingLabel = CreatePackingLabel();
        foreach (var line in packingLabel)
        {
            Console.WriteLine(line);
        }

    }

    public List<string> CreateShippingLabel()
    {
        List<string> shippingLabel = new List<string>();

        shippingLabel.Add(customer.ShippingLabelName());
        shippingLabel.Add(customer.CustomerShippingLabelAddress());

        return shippingLabel;
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        List<string> shippingLabel = CreateShippingLabel();
        foreach (var line in shippingLabel)
        {
            Console.WriteLine(line);
        }
    }

    public void DisplayOrder()
    {
        DisplayPackingLabel();
        DisplayShippingLabel();
        double totalCost = ComputeTotalCost();
        Console.WriteLine($"Total Cost: {totalCost}");
    }
}