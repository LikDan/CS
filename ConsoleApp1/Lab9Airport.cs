namespace ConsoleApp1;

public class Lab9Airport
{
    private readonly List<Lab9Flight> _flights = new();
    public List<Lab9Flight> Flights => _flights;

    public void AddFlight(Lab9Flight flight) => _flights.Add(flight);

    public string GetInfoByNumber(string number)
    {
        var i = _flights.FindIndex(f => f.RouteNumber == number);
        return $"{i}: {_flights[i]}";
    }

    public string GetInfoByTime(DateTime dateTime)
    {
        var flights = _flights.Where(f => f.DepartmentTime >= dateTime && f.DepartmentTime <= dateTime.AddHours(1));
        return ToString(flights);
    }

    public string GetInfoByArrival(string arrival)
    {
        var flights = _flights.Where(f => f.Arrival == arrival);
        return ToString(flights);
    }

    public static string ToString(IEnumerable<Lab9Flight> flights)
    {
        var f = flights.ToArray(); 
        Array.Sort(f, (f1, f2) => f1.CompareTo(f2));
        return string.Join("\n", f.Select(v => v.ToString()));
    }
}