using ConsoleApp1.Labs._12;
using ConsoleApp1.Practices._11;

namespace ConsoleApp1.Practices._12;

internal class Worker: WorkerManagement, IComparable<Worker>, ICloneable
{
    private DateOnly _birthday;

    private uint _experience;
    private double _salary;
    
    public Worker(uint experience, double salary, DateOnly birthday, string name, string job, Sex sex, int sickDays,
        int vacation, double bonus, List<Tax> taxes) : base(sickDays, vacation, bonus, taxes)
    {
        Experience = experience;
        Salary = salary;
        Birthday = birthday;
        Name = name;
        Job = job;
        Sex = sex;
    }

    public DateOnly Birthday
    {
        get => _birthday;
        set
        {
            if (2022 - value.Year > 150)
            {
                throw new MyException("bad year");
            }

            _birthday = value;
        }
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
        set
        {
            if (value > DateTime.Now.Year - Birthday.Year + 14) return;
            _experience = value;
        }
    }

    public Sex Sex { get; set; }

    public override double GetSalary()
    {
        var texesAmount = Taxes.Sum(v => v.Percent);
        var daysOff = Vacation + SickDays;
        return (Salary / 30 * (30 - daysOff) + Salary / 30 / 2 * daysOff) * (1 - texesAmount / 100);
    }

    public int CompareTo(Worker? other) => Salary.CompareTo(other?.Salary);

    public override string ToString()
    {
        return $"{Name} {Birthday:d} {Sex} -> {Job} ({Experience}) {_salary:C}";
    }

    public object Clone() => new Worker(Experience, Salary, Birthday, Name, Job, Sex, SickDays, Vacation, Bonus, Taxes);

    public void AddTax(Tax tax)
    {
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
            birthday: DateOnly.Parse(words[2]),
            name: words[3],
            job: words[4],
            sex: sex,
            sickDays: Convert.ToInt32(words[6]),
            vacation: Convert.ToInt32(words[7]),
            bonus: Convert.ToDouble(words[8]),
            taxes: new List<Tax>()
        );
    }
}