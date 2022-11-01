using Newtonsoft.Json;

namespace ConsoleApp1.Labs._9;

public class Lab9
{
    
    public static void Launch()
    {
        var arr = new Mod5Array(new[]{0,1,2,3,4,5,6,7,8,9,10,15});
        Console.WriteLine(arr.Sum());
        Console.WriteLine(arr.Amount());
    
        var flights = JsonConvert.DeserializeObject<Flight[]>(File.ReadAllText(@"/home/user/RiderProjects/CS/ConsoleApp1/Labs/9/data.json"))!;
        var airport = new Airport();
        foreach (var flight in flights) airport.AddFlight(flight);
        
        Console.WriteLine(airport.GetInfoByNumber("111111"));
        
        var time = DateTime.Parse(Console.ReadLine() ?? DateTime.Today.ToString("s"));
        Console.WriteLine(airport.GetInfoByTime(time));
        
        Console.WriteLine(airport.GetInfoByArrival("Boston"));
    }
}