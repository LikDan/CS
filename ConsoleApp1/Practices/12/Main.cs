using Newtonsoft.Json;

namespace ConsoleApp1.Practices._12;

public class Practice12
{
    public static void Launch()
    {
        var workersArray =
            JsonConvert.DeserializeObject<Worker[]>(
                File.ReadAllText(@"/Users/likdan/RiderProjects/CS/ConsoleApp1/Practices/12/data.json"))!;
        
        Array.Sort(workersArray);

        var clonned = workersArray.Last().Clone();
        Console.WriteLine(clonned);
    }
}