namespace ConsoleApp1.Practices._18;

public class Car: IComparable<Car>
{
    public string Name { get; set; }
    public string Info { get; set; }

    public Car(string name, string info)
    {
        Name = name;
        Info = info;
    }

    public override string ToString() => $"{Name}: {Info}";

    public int CompareTo(Car? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;
        return string.Compare(Info, other.Info, StringComparison.Ordinal);
    }
}