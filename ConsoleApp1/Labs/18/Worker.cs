namespace ConsoleApp1.Labs._18;

[Serializable]
public struct Worker
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Sex { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public override string ToString() => $"{Age}";
}