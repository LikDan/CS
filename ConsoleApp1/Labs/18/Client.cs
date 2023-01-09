namespace ConsoleApp1.Labs._18;

public struct Client
{
    public string Name { get; set; }
    public string Account { get; set; }
    public double Amount { get; set; }
    public int Year { get; set; }

    public override string ToString() => $"{Amount}$, {Year}";
}