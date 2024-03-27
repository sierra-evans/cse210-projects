public class Product
{
    private string name;
    private string productId;
    private int pricePerUnit;
    private int quantity;

    public Product(string name, string productId, int pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public int ComputeProductCost()
    {
        int productCost = pricePerUnit * quantity;
        return productCost;
    }

    public string PackingLabelProduct()
    {
        return $"Name: {name}, ID: {productId}";
    }
}