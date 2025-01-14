public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void UpdatePrice(double percentage)
    {
        Price = Price * (1.0 + percentage / 100.0);
    }

    public double Total(double price, double quantity)
    {
        return price * quantity;
    }

    public override string ToString()
    {
        return Name + ", "+ "$" + Price.ToString("F2") + ", "+Quantity;
    }
}