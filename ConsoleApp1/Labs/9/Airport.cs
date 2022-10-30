namespace ConsoleApp1.Labs._9;

public class Airport
{
    public List<Flight> Flights { get; } = new();

    public void AddFlight(Flight flight)
    {
        Flights.Add(flight);
    }

    public string GetInfoByNumber(string number)
    {
        var i = Flights.FindIndex(f => f.RouteNumber == number);
        return $"{i}: {Flights[i]}";
    }

    public string GetInfoByTime(DateTime dateTime)
    {
        var flights = Flights.Where(f => f.DepartmentTime >= dateTime && f.DepartmentTime <= dateTime.AddHours(1));
        return ToString(flights);
    }

    public string GetInfoByArrival(string arrival)
    {
        var flights = Flights.Where(f => f.Arrival == arrival);
        return ToString(flights);
    }

    public static string ToString(IEnumerable<Flight> flights)
    {
        var f = flights.ToArray();
        Array.Sort(f, (f1, f2) => f1.CompareTo(f2));
        return string.Join("\n", f.Select(v => v.ToString()));
    }
}