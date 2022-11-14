namespace ConsoleApp1.Practices._11;

public class Tax
{
    public Tax(string name, double percent)
    {
        Name = name;
        Percent = percent;
    }

    public string Name { get; set; }
    public double Percent { get; set; }
}