namespace ConsoleApp1.Practices._13;

public class Statistic
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value.ToTitleCase();
    }

    public List<Check> Visits { get; set; }
}