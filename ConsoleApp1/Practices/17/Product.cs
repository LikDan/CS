namespace ConsoleApp1.Practices._17;

public class Product
{
    public string Name { get; set; }
    public uint Weight { get; set; }

    public Product(string name, uint weight)
    {
        Name = name;
        Weight = weight;
    }

    public override string ToString() => $"Name: {Name}, Weight: {Weight}";
}