namespace ConsoleApp1.Practices._14;

public class Statistic
{
    public delegate void CardDeskHandler(object? o, CheckEventArgs args);
    public event CardDeskHandler? Event;
    
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
        Event?.Invoke(this, new CheckEventArgs("AddVisit"));
        Visits.Add(visit);
    }

    public double GetAvgSum()
    {
        Event?.Invoke(this, new CheckEventArgs("GetAvgSum"));
        return Visits.Average(v => v.Price);
    }
}