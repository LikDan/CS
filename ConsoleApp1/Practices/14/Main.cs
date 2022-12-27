namespace ConsoleApp1.Practices._14;

public class Practice14
{
    private delegate double[] Sorter(double[] arr);

    public static double[] SortByMiddle(double[] arr)
    {
        var middleElement = arr[arr.Length / 2];
        Array.Sort(arr, (d1, d2) => (int)(d1 > middleElement ? d2 - d1 : d1 - d2));
        return arr;
    }

    public static double[] SortBy3(double[] arr)
    {
        var newArr = arr.Select(v => (double)((int)(v / 3) * 3)).ToArray();
        Array.Sort(newArr);
        return newArr;
    }

    public static void Log(object o, CheckEventArgs a)
    {
        Console.WriteLine(a.Message);
    }

    public static void Launch()
    {
        try
        {
            Console.WriteLine("Enter array via space");
            var array = Console.ReadLine()!.Split(" ").Select(Convert.ToDouble).ToArray();

            Console.WriteLine("Select action");
            var a = Console.ReadLine();
            Sorter sorter = a switch
            {
                "1" => SortByMiddle,
                "2" => SortBy3,
                _ => throw new ApplicationException("Bad action")
            };

            array = sorter(array);
            Console.WriteLine(string.Join(" ", array.Select(Convert.ToString)));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        var c1 = new Check(10, "birthday", 1, "dish");
        c1.Event += Log;
        
        var c2 = new Check(0, "", 2, "dish");
        c2.Event += Log;
        
        var c3 = new Check(10, "birthday", 3, "dish2");
        c3.Event += Log;

        var checks = new[] { c1, c2, c3 };

        var s = new Statistic("Restaurant", checks.ToList());
        s.Event += Log;
        
        Console.WriteLine(s.GetAvgSum());
        Console.WriteLine(s.Visits[0].HasDiscount);
        Console.WriteLine(s.Visits[0].DiscountAmount);
    }
}