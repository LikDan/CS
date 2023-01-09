using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ConsoleApp1.Practices._17;

public class Practice17
{
    public static void PrintInfo(List<object> list)
    {
        Console.WriteLine(list.Count);
        Console.WriteLine(string.Join("\t", list.ToArray().Select(el => el?.ToString())));
    }

    public static void Task1()
    {
        Console.WriteLine("Enter number amount, min and max values");
        var a = Convert.ToInt32(Console.ReadLine());
        var min = Convert.ToInt32(Console.ReadLine());
        var max = Convert.ToInt32(Console.ReadLine());

        var r = new Random();
        var list = new ArrayList();
        for (var i = 0; i < a; i++)
        {
            var num = r.Next(min, max);
            list.Add(num);
        }

        PrintInfo(list.ToArray().ToList());
        for (var i = 0; i < 5; i++)
        {
            var w = Console.ReadLine();
            if (string.IsNullOrEmpty(w)) break;

            list.Add(w);
        }

        PrintInfo(list.ToArray().ToList());

        var minEl = list.ToArray().Where(el => el is string).MinBy(el => (el as string)!.Length) as string;
        var minIndex = list.IndexOf(minEl);
        list = new ArrayList(list.ToArray().Where((_, i) => i % 2 == 0 && i != minIndex).ToArray());
        PrintInfo(list.ToArray().ToList());
    }

    public static void Task2()
    {
        var list = new List<Character>
        {
            new("Name", "Ability", 100),
            new("Name2", "Ability", 50),
            new("Name3", "Ability", 25),
            new("Name4", "Ability", 0)
        };
        PrintInfo(list.Select(el => el as object).ToList());


        Console.WriteLine("Enter name, ability and HP");
        var name = Console.ReadLine()!;
        var ability = Console.ReadLine()!;
        var hp = Convert.ToUInt32(Console.ReadLine());

        list.Add(new Character(name, ability, hp));
        PrintInfo(list.Select(el => el as object).ToList());

        list.Add(new Character("Ciri", "Superspeed", Convert.ToUInt32(list.Sum(el => el.HP))));
        PrintInfo(list.Select(el => el as object).ToList());

        list.Sort();
        list = list.ToArray()[3..].ToList();
        PrintInfo(list.Select(el => el as object).ToList());
    }

    public static void Task3()
    {
        Console.WriteLine("Enter n, a, b");
        var n = Convert.ToInt32(Console.ReadLine());
        var a = Convert.ToInt32(Console.ReadLine());
        var b = Convert.ToInt32(Console.ReadLine());
        
        var numbers = File.ReadAllText("/Users/likdan/RiderProjects/CS/ConsoleApp1/Practices/17/task3.txt")
            .Split(" ")
            .Select(n => Convert.ToInt32(n))
            .ToArray();

        var range = numbers[a..(b + 1)];
        var notRangeNumbers = numbers.Where((t, i) => i < a || i > b).ToList();

        var numbersList = new List<int>();
        numbersList.AddRange(notRangeNumbers.Where(el => el < n));
        numbersList.AddRange(range);
        numbersList.AddRange(notRangeNumbers.Where(el => el >= n));

        File.WriteAllText(
            "/Users/likdan/RiderProjects/CS/ConsoleApp1/Practices/17/task3Res.txt",
            string.Join(" ", numbersList)
        );
    }

    public static void PrintDict(Dictionary<string, Product> d)
    {
        Console.WriteLine(string.Join("\n", d.Select(el => el.Key + " -> " + el.Value)));
    }
    
    public static void Task4()
    {
        var products = new Dictionary<string, Product>
        {
            { "Name", new Product("Name", 10) },
            { "Name1", new Product("Name1", 10) },
            { "Name2", new Product("Name2", 10) },
            { "Name3", new Product("Name3", 10) },
            { "Name4", new Product("Name4", 10) },
            { "Name5", new Product("Name5", 10) },
            { "Name6", new Product("Name6", 10) },
            { "Name7", new Product("Name7", 10) },
            { "Mame8", new Product("Mame8", 10) },
            { "Mame9", new Product("Mame9", 10) },
            { "Mame10", new Product("Mame10", 10) }
        };
        PrintDict(products);

        Console.WriteLine("Enter name and weight");
        var name = Console.ReadLine()!;
        var weight = Convert.ToUInt32(Console.ReadLine());
        products.Add(name, new Product(name, weight));
        PrintDict(products);

        products = products
            .Where(p => !p.Key.StartsWith("M"))
            .ToDictionary(i => i.Key, i => i.Value);
        PrintDict(products);
    }
    
    public static void Launch()
    {
        Task4();
        Task3();
        Task2();
        Task1();
    }
}