namespace ConsoleApp1.Labs._9;

public class Flight : IComparable<Flight>
{
    private string _routeNumber;

    public Flight(string routeNumber, string arrival, DateTime departmentTime)
    {
        _routeNumber = routeNumber.Length == 6 ? routeNumber : new string('?', 6);
        Arrival = arrival;
        DepartmentTime = departmentTime;
    }

    public string Arrival { get; set; }

    public string RouteNumber
    {
        get => _routeNumber;
        set
        {
            if (value.Length != 6) return;
            _routeNumber = value;
        }
    }

    public DateTime DepartmentTime { get; set; }


    public int CompareTo(Flight? other)
    {
        return DepartmentTime.CompareTo(other?.DepartmentTime);
    }

    public override string ToString()
    {
        return $"#{_routeNumber} -> {Arrival} {DepartmentTime:g}";
    }
}