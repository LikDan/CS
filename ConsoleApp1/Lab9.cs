// using ConsoleApp1;
// using Newtonsoft.Json;
//
// var flights = JsonConvert.DeserializeObject<Lab9Flight[]>(File.ReadAllText("P:\\CS\\ConsoleApp1\\Lab9.json"))!;
// var airport = new Lab9Airport();
// foreach (var flight in flights) airport.AddFlight(flight);
//
// Console.WriteLine(airport.GetInfoByNumber("111111"));
//
// var time = DateTime.Parse(Console.ReadLine() ?? DateTime.Today.ToString("s"));
// Console.WriteLine(airport.GetInfoByTime(time));
