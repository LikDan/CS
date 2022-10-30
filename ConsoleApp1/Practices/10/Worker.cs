namespace ConsoleApp1.Practices._10;

public class Worker
{
    private DateOnly _birthday;

    private uint _experience;
    private double _salary;

    public Worker()
    {
        Name = "";
        Job = "";
        Sex = Sex.Undefined;
        Birthday = DateOnly.MinValue;
        Salary = 0;
    }

    public Worker(uint experience, double salary, DateOnly birthday, string name, string job, Sex sex)
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

    public Sex Sex { get; set; }

    public override string ToString()
    {
        return $"{Name} {Birthday:d} {Sex} -> {Job} ({Experience}) {_salary:C}";
    }

    public static Worker Parse(string str)
    {
        var words = str.Split(" ");

        if (!Enum.TryParse(words[5], out Sex sex)) sex = Sex.Undefined;

        return new Worker(
            Convert.ToUInt32(words[0]),
            Convert.ToDouble(words[1]),
            DateOnly.Parse(words[2]),
            words[3],
            words[4],
            sex
        );
    }
}