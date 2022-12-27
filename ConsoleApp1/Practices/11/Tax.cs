namespace ConsoleApp1.Practices._11;

[Serializable]
public class Tax
{
    public Tax(string name, double percent)
    {
        Name = name;
        Percent = percent;
    }
    
    public Tax()
    {
    }
    
    

    public string Name { get; set; }
    public double Percent { get; set; }
}