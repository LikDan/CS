namespace ConsoleApp1.Practices._18;

public class Practice18
{
    public static void Launch()
    {
        var arr = new[] { "a", "aa", "aaa", "ba", "b", "bb", "bbb" };
        var arr2 = arr.Where(el => el.Contains('i'));
        Console.WriteLine(string.Join("\t", arr2));

        arr = new[] { "LightYellow", "Yellow", "Dark" };
        arr2 = arr.Where(el => el.Contains("Yellow"));
        Console.WriteLine(string.Join("\t", arr2));

        var arr3 = new[] { new Car("Audi", "Some info"), new Car("NeAudi", "Some info") };
        var arr4 = arr3.Where(el => el.Name == "Audi");
        Console.WriteLine(string.Join("\t", arr4.Select(el => el.ToString())));

        var arr5 = new[] { new Product("Audi", true), new Product("NeAudi", false) };
        var arr6 = arr5.Where(el => el.Expired);
        Console.WriteLine(string.Join("\t", arr6.Select(el => el.ToString())));

        arr3 = new[] { new Car("Audi", "Some info"), new Car("NeAudi", "Some info") };
        var arr32 = new[] { new Car("Audi", "Some info"), new Car("NeAudi", "A") };
        arr3 = arr3.Union(arr32).ToArray();
        Console.WriteLine(string.Join("\t", arr3.Select(el => el.ToString())));

        arr5 = new[]
        {
            new Product("Audi", 10, 10, "C1"),
            new Product("Audi", 10, 12.5, "C1"),
            new Product("Audi", 10, 10, "C2")
        };

        arr2 = arr5.GroupBy(e => e.Category).Select(e => $"{e.Key}: {e.Average(p => p.Price)}");
        Console.WriteLine(string.Join("\n", arr2));
    }
}