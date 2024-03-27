public class Order
{
    List<Product> products;
    Customer customer;
    private int identifier;

    public Order(int identifier)
    {
        this.identifier = identifier;
        products = GetProducts();
        customer = GetCustomer();
    }

    public List<Product> GetProducts()
    {
        if (identifier == 1)
        {
            List<Product> products = new List<Product>();
            Product product1 = new Product("tank top", "623A", 12, 3);
            products.Add(product1);
            Product product2 = new Product("sweater", "603B", 18, 2);
            products.Add(product2);
            return products;
        }
        else
        {
            List<Product> products = new List<Product>();
            Product product1 = new Product("face wash", "323C", 10, 2);
            products.Add(product1);
            Product product2 = new Product("face lotion", "303D", 8, 3);
            products.Add(product2);
            return products;
        }
    }

    public Customer GetCustomer()
    {
        if (identifier == 1)
        {
            customer = new Customer("Sierra", 1);
            return customer;
        }
        else
        {
            customer = new Customer("Sariah", 2);
            return customer;
        }
    }

    public int ComputeTotalCost()
    {
        int totalCost = 0;

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
        Console.WriteLine();
        DisplayShippingLabel();
        Console.WriteLine();
        double totalCost = ComputeTotalCost();
        Console.WriteLine($"Total Cost: {totalCost}");
    }
}