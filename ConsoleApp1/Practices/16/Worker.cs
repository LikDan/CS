using ConsoleApp1.Practices._11;

namespace ConsoleApp1.Practices._16;

[Serializable]
public class Worker : WorkerManagement, IComparable<Worker>, ICloneable
{
    public delegate void CardDeskHandler(object? o, WorkerEventArgs args);
    [field: NonSerialized]
    public event CardDeskHandler? Event;

    private uint _experience;
    private double _salary;

    public Worker(uint experience, double salary, string name, string job, Sex sex, int sickDays,
        int vacation, double bonus, List<Tax> taxes) : base(sickDays, vacation, bonus, taxes)
    {
        Experience = experience;
        Salary = salary;
        Name = name;
        Job = job;
        Sex = sex;
    }

    public Worker() : base(0, 0, 0, new List<Tax>())
    {
    }

    public string Name { get; set; }
    public string Job { get; set; }

    public double Salary
    {
        get => _salary;
        set
        {
            if (value < 1160)
            {
                _salary = 1160;
                return;
            }

            _salary = value;
        }
    }

    public uint Experience
    {
        get => _experience;
        set => _experience = value;
    }

    public Sex Sex { get; set; }

    public override double GetSalary()
    {
        Event?.Invoke(this, new WorkerEventArgs("Get Salary"));
        var texesAmount = Taxes.Sum(v => v.Percent);
        var daysOff = Vacation + SickDays;
        return (Salary / 30 * (30 - daysOff) + Salary / 30 / 2 * daysOff) * (1 - texesAmount / 100);
    }

    public int CompareTo(Worker? other) => Salary.CompareTo(other?.Salary);

    public override string ToString()
    {
        return $"{Name} {Sex} -> {Job} ({Experience}) {_salary:C}";
    }

    public object Clone() => new Worker(Experience, Salary, Name, Job, Sex, SickDays, Vacation, Bonus, Taxes);

    public void AddTax(Tax tax)
    {
        Event?.Invoke(this, new WorkerEventArgs("Tax Added"));
        Taxes.Add(tax);
    }

    public override int DaysOnWork()
    {
        return 30 - (SickDays + Vacation);
    }

    public static Worker Parse(string str)
    {
        var words = str.Split(" ");

        if (!Enum.TryParse(words[5], out Sex sex)) sex = Sex.Undefined;

        return new Worker(
            experience: Convert.ToUInt32(words[0]),
            salary: Convert.ToDouble(words[1]),
            name: words[2],
            job: words[3],
            sex: sex,
            sickDays: Convert.ToInt32(words[5]),
            vacation: Convert.ToInt32(words[6]),
            bonus: Convert.ToDouble(words[7]),
            taxes: new List<Tax>()
        );
    }
}