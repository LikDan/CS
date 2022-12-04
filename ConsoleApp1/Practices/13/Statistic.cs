namespace ConsoleApp1.Practices._13;

public class Statistic
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value.ToTitleCase();
    }

    public List<Check> Visits { get; private set; }

    public Statistic(string name, List<Check> visits)
    {
        Name = name;
        Visits = visits;
    }

    public void AddVisit(Check visit)
    {
        Visits.Add(visit);
    }

    public double GetAvgSum()
    {
        return Visits.Average(v => v.Price);
    }
}