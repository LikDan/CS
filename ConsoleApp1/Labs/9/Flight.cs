namespace ConsoleApp1.Labs._9;

public class Flight : IComparable<Flight>
{
    private string _routeNumber;

    public Flight(string routeNumber, string arrival, DateTime departmentTime)
    {
        RouteNumber = routeNumber;
        Arrival = arrival;
        DepartmentTime = departmentTime;
    }

    public string Arrival { get; set; }

    public string RouteNumber
    {
        get => _routeNumber;
        set
        {
            if (value.Length != 6) value = new string('?', 6);
            _routeNumber = value;
        }
    }

    public DateTime DepartmentTime { get; set; }


    public int CompareTo(Flight? other)
    {
        return DepartmentTime.CompareTo(other?.DepartmentTime);
    }

    public static bool operator >(Flight f1, Flight f2)
    {
        return f1.DepartmentTime > f2.DepartmentTime;
    }
    public static bool operator <(Flight f1, Flight f2)
    {
        return f1.DepartmentTime < f2.DepartmentTime;
    } 
    
    public override string ToString()
    {
        return $"#{_routeNumber} -> {Arrival} {DepartmentTime:g}";
    }
}