namespace ConsoleApp1.Labs._10;

public class DayPhoneCalls
{
    private readonly List<PhoneCall> _calls = new();

    public DayPhoneCalls()
    {
    }

    public void AddCall(PhoneCall call)
    {
        _calls.Add(call);
    }

    public PhoneCall[] GetCalls() => _calls.ToArray();

    public int Amount() => _calls.Count;
    public double TotalMinutes() => _calls.Sum(call => call.Length);
    public double TotalSum() => _calls.Sum(call => call.TotalSum());
}