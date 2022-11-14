namespace ConsoleApp1.Practices._11;

internal class Programmer: Worker
{
    public string Lang { get; set; }

    public Programmer(string lang, uint experience, double salary, DateOnly birthday, string name, string job, Sex sex, int sickDays, int vacation, double bonus, List<Tax> taxes) : base(experience, salary, birthday, name, job, sex, sickDays, vacation, bonus, taxes)
    {
        Lang = lang;
    }
}