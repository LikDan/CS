namespace ConsoleApp1.Labs._11;

public class Lab11
{
    public static void Launch()
    {
        var apartments = new[]
        {
            new Flat("", 0, 0),
            new Flat("Address", 0, 1),
            new Flat("adadasdsa", 123, 123),
            new Flat("aswdfdsfdswfewfewf", 12325.132, 0),
            new Flat("asdsdadsadasdsadsa", 438, 123),
        };

        Console.WriteLine(apartments.First().Clone());
        
        Array.Sort(apartments);
        Console.WriteLine(string.Join(", ", apartments.Select(a => a.ToString())));
    }
}