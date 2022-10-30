using Newtonsoft.Json;

var workersArray = JsonConvert.DeserializeObject<Pract10Worker[]>(File.ReadAllText("P:\\CS\\ConsoleApp1\\Pract10.json"))!;
var workers = new Pract10WorkersList(workersArray);

var worker = Pract10Worker.Parse("1 -10 2004/01/01 Chupilkin Rat Male"); 
workers.Add(worker);

workers.SortBy("Birthday");
Console.WriteLine(workers.ToString());

Console.WriteLine();

Console.WriteLine(workers.MinBy("Salary"));
Console.WriteLine(workers.MaxBy("Experience"));

