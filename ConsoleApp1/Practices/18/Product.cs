namespace ConsoleApp1.Practices._18;

public class Product
{
    public string Name { get; set; }
    public bool Expired { get; set; }
    public double Weight { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }

    public Product(string name, bool expired)
    {
        Name = name;
        Expired = expired;
    }

    public Product(string name, double weight, double price, string category)
    {
        Name = name;
        Weight = weight;
        Price = price;
        Category = category;
    }

    public override string ToString() => $"{Name}: {Expired}";
}