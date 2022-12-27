namespace ConsoleApp1.Practices._11;

[Serializable]
public abstract class WorkerManagement
{
    private int _sickDays;

    public int SickDays
    {
        get => _sickDays;
        set => _sickDays = value > 0 ? value : 0;
    }

    private int _vacation;

    public int Vacation
    {
        get => _vacation;
        set => _vacation = value > 0 ? value : 0;
    }

    public double Bonus { get; set; }
    public List<Tax> Taxes { get; set; }

    protected WorkerManagement(int sickDays, int vacation, double bonus, List<Tax> taxes)
    {
        SickDays = sickDays;
        Vacation = vacation;
        Bonus = bonus;
        Taxes = taxes;
    }

    public virtual double GetSalary()
    {
        return 0.0;
    }

    public abstract int DaysOnWork();
}