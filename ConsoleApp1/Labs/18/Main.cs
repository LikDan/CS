using System.Collections;
using Newtonsoft.Json;

namespace ConsoleApp1.Labs._18;

public class Lab18
{
    public static int ParsePart(string part)
    {
        if (int.TryParse(part, out var i)) return i;

        var st = ParseBrackets(part[2..^1]);
        return part.Contains('M') ? Math.Max(st.Pop(), st.Pop()) : Math.Min(st.Pop(), st.Pop());
    }

    public static Stack<int> ParseBrackets(string contains)
    {
        var openBracesAmount = 0;
        var p1 = new string(contains.TakeWhile(c =>
        {
            if (c == '(') openBracesAmount++;
            else if (c == ')') openBracesAmount--;

            return c != ',' || openBracesAmount != 0;
        }).ToArray());

        var p2 = contains[(p1.Length + 1)..];

        var st = new Stack<int>(2);
        st.Push(ParsePart(p2));
        st.Push(ParsePart(p1));

        return st;
    }

    public static void Launch()
    {
        var expr = File.ReadAllText("/Users/likdan/RiderProjects/CS/ConsoleApp1/Labs/18/task1.txt");
        Console.WriteLine(ParsePart(expr));

        var workers =
            JsonConvert.DeserializeObject<List<Worker>>(
                File.ReadAllText("/Users/likdan/RiderProjects/CS/ConsoleApp1/Labs/18/task2.json"))!;

        var workersQueue = new Queue<Worker>();
        workers.ForEach(w =>
        {
            if (w.Age > 30) workersQueue.Enqueue(w);
            else Console.WriteLine(w);
        });

        Console.WriteLine(string.Join("\n", workersQueue.Select(w => w.ToString())));


        var clients =
            JsonConvert.DeserializeObject<List<Client>>(
                File.ReadAllText("/Users/likdan/RiderProjects/CS/ConsoleApp1/Labs/18/task3.json"))!;

        var newClients = clients.Where(c => c.Year == 2022).ToList();
        newClients.Sort((c1, c2) => (int)(c1.Amount - c2.Amount));
        Console.WriteLine(string.Join("\n", newClients.Select(c => c.ToString())));

        var ht = new Hashtable();
        while (true)
        {
            Console.WriteLine(
                "Select action (1 -> add disk 2 -> remove disk 3 -> add song -> 4 remove song 5 -> view catalog 6 -> view disk 7 -> find song)");
            var a = Console.ReadLine();
            switch (a)
            {
                case "1": 
                    Console.WriteLine("Write catalog and disk");
                    var c1 = Console.ReadLine() ?? "";
                    var d1 = Console.ReadLine() ?? "";
                    
                    ht[c1] ??= new Hashtable();
                    (ht[c1] as Hashtable).Add(d1, new List<string>());
                    
                    break;
                case "2": 
                    Console.WriteLine("Write catalog and disk");
                    var c2 = Console.ReadLine() ?? "";
                    var d2 = Console.ReadLine() ?? "";
                    
                    ht[c2] ??= new Hashtable();
                    (ht[c2] as Hashtable).Remove(d2);
                    
                    break;
                case "3": 
                    Console.WriteLine("Write catalog, disk and song");
                    var c3 = Console.ReadLine() ?? "";
                    var d3 = Console.ReadLine() ?? "";
                    var s3 = Console.ReadLine() ?? "";
                    
                    ht[c3] ??= new Hashtable();
                    (ht[c3] as Hashtable)[d3] ??= new List<string>();
                    ((ht[c3] as Hashtable)[d3] as List<string>).Add(s3);
                    
                    break;
                case "4": 
                    Console.WriteLine("Write catalog, disk and song");
                    var c4 = Console.ReadLine() ?? "";
                    var d4 = Console.ReadLine() ?? "";
                    var s4 = Console.ReadLine() ?? "";
                    
                    ht[c4] ??= new Hashtable();
                    (ht[c4] as Hashtable)[d4] ??= new List<string>();
                    ((ht[c4] as Hashtable)[d4] as List<string>).Remove(s4);
                    
                    break;
                case "5":
                    Console.WriteLine("Write catalog");
                    var c5 = Console.ReadLine() ?? "";
                    ht[c5] ??= new Hashtable();
                    var table5 = ht[c5] as Hashtable;
                    foreach (DictionaryEntry o in table5)
                    {
                        Console.WriteLine($"{o.Key} -> [{string.Join(", ", o.Value as List<string>)}]");
                    }
                    
                    break;
                case "6":
                    Console.WriteLine("Write catalog and disk");
                    var c6 = Console.ReadLine() ?? "";
                    var d6 = Console.ReadLine() ?? "";
                    
                    ht[c6] ??= new Hashtable();
                    (ht[c6] as Hashtable)[d6] ??= new List<string>();
                    var songs6 = (ht[c6] as Hashtable)[d6] as List<string>;
                    Console.WriteLine($"[{string.Join(", ", songs6)}]");
                    
                    break;
                case "7":
                    var s7 = Console.ReadLine() ?? "";

                    foreach (DictionaryEntry c in ht)
                    {
                        foreach (DictionaryEntry d in c.Value as Hashtable)
                        {
                            if ((d.Value as List<string>).Contains(s7))
                            {
                                Console.WriteLine($"{c.Key} -> {d.Key} -> {s7}");
                            }
                        }
                    }
                    
                    break;
                default: return;
            }
        }
    }
}