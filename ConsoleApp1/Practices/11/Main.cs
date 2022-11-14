using Newtonsoft.Json;

namespace ConsoleApp1.Practices._11;

public class Practice11
{
    public static void Launch()
    {
        var reflection = new Reflection<Worker>();

        var workersArray =
            JsonConvert.DeserializeObject<Worker[]>(File.ReadAllText(@"/Users/likdan/RiderProjects/CS/ConsoleApp1/Practices/11/data.json"))!;
        var workers = new SmartList<Worker>(reflection, workersArray);

        var worker = Worker.Parse("1 -10 2004/01/01 Chupilkin Rat Male 1 2 3");
        worker.AddTax(new Tax("Tax", 40));
        workers.Add(worker);

        var programmer = new Programmer("kotlin", 10, 100000, DateOnly.MaxValue, "me", "programmer", Sex.Male, 2, 0,
            1000, new List<Tax>());
        workers.Add(programmer);
        
        workers.SortBy("Birthday");
        Console.WriteLine(workers.ToString());

        Console.WriteLine();

        Console.WriteLine(workers.MinBy("Salary"));
        Console.WriteLine(workers.MaxBy("Experience"));
    }
}