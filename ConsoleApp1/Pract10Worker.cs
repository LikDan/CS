using ConsoleApp1;

public class Pract10Worker
{
    public DateOnly Birthday
    {
        get => _birthday;
        set
        {
            if (2022 - value.Year > 150)
            {
                _birthday = DateOnly.FromDateTime(DateTime.Now.AddYears(-18));
                return;
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
            if (value < 200)
            {
                _salary = 200;
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

    public Pract10Sex Sex { get; set; }

    private uint _experience;
    private double _salary;
    private DateOnly _birthday;

    public Pract10Worker()
    {
        Name = "";
        Job = "";
        Sex = Pract10Sex.Undefined;
        Birthday = DateOnly.MinValue;
        Salary = 0;
    }

    public Pract10Worker(uint experience, double salary, DateOnly birthday, string name, string job, Pract10Sex sex)
    {
        Experience = experience;
        Salary = salary;
        Birthday = birthday;
        Name = name;
        Job = job;
        Sex = sex;
    }

    public override string ToString() => $"{Name} {Birthday:d} {Sex} -> {Job} ({Experience}) {_salary:C}";

    public static Pract10Worker Parse(string str)
    {
        var words = str.Split(" ");

        if (!Enum.TryParse(words[5], out Pract10Sex sex)) sex = Pract10Sex.Undefined;

        return new Pract10Worker(
            experience: Convert.ToUInt32(words[0]),
            salary: Convert.ToDouble(words[1]),
            birthday: DateOnly.Parse(words[2]),
            name: words[3],
            job: words[4],
            sex: sex
        );
    }

    public T GetFiledByName<T>(string name) => (T)typeof(Pract10Worker).GetProperty(name)!.GetValue(this)!;

    public int CompareByFieldName<T>(string name, Pract10Worker other) =>
        ((IComparable)GetFiledByName<T>(name)!).CompareTo((IComparable)other.GetFiledByName<T>(name)!);
}