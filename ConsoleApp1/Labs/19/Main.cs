using Newtonsoft.Json;

namespace ConsoleApp1.Labs._19;

public class Lab19
{
    public static void Launch()
    {
        var arr = new[] { 1, 2, -3, 4, -0.6, 5, -23, 4132, 0, 32, 4, 9.4 }.ToList();
        Console.WriteLine(arr.Count(el => el > 0));
        var li = arr.FindLastIndex(el => el == 0);
        Console.WriteLine(arr.ToArray()[li..].Sum());
        arr.Sort((d, d1) => (int) ((Math.Abs(d) - Math.Abs(d1)) * 100)); //100 -> fraction
        Console.WriteLine(string.Join(" ~ ", arr));
        
        var workers =
            JsonConvert.DeserializeObject<List<Worker>>(
                File.ReadAllText("/Users/likdan/RiderProjects/CS/ConsoleApp1/Labs/19/task.json"))!;

        Console.WriteLine(string.Join("\n", workers.GroupBy(worker => worker.Occupation).Select(v => $"{v.Key} -> {v.Average(worker => worker.Age)}")));
    }
}