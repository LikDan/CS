using Newtonsoft.Json;

namespace ConsoleApp1.Practices._10;

public class Practice10
{
    public static void Launch()
    {
        var reflection = new Reflection<Worker>();

        var workersArray =
            JsonConvert.DeserializeObject<Worker[]>(File.ReadAllText(@"P:\CS\ConsoleApp1\Practices\10\data.json"))!;
        var workers = new SmartList<Worker>(reflection, workersArray);

        var worker = Worker.Parse("1 -10 2004/01/01 Chupilkin Rat Male");
        workers.Add(worker);

        workers.SortBy("Birthday");
        Console.WriteLine(workers.ToString());

        Console.WriteLine();

        Console.WriteLine(workers.MinBy("Salary"));
        Console.WriteLine(workers.MaxBy("Experience"));
    }
}