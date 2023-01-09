namespace ConsoleApp1.Labs._19;

[Serializable]
public struct Worker
{
    public string LastName { get; set; }
    public string Occupation { get; set; }
    public string Region { get; set; }
    public int Age { get; set; }

    public override string ToString() => $"{Age}";
}