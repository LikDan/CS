namespace ConsoleApp1;

public class Lab9Flight : IComparable<Lab9Flight>
{
    private string _routeNumber;
    
    public string Arrival{ get; set; }

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

    public Lab9Flight(string routeNumber, string arrival, DateTime departmentTime)
    {
        _routeNumber = routeNumber.Length == 6 ? routeNumber : new string('?', 6);
        Arrival = arrival;
        DepartmentTime = departmentTime;
    }

    public override string ToString() => $"#{_routeNumber} -> {Arrival} {DepartmentTime:g}";


    public int CompareTo(Lab9Flight? other) => DepartmentTime.CompareTo(other?.DepartmentTime);
}