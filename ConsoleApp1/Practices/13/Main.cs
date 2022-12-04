namespace ConsoleApp1.Practices._13;

public class Practice13
{
    public static void Launch()
    {
        var checks = new[]
        {
            new Check(10, "birthday", 1,"dish"),
            new Check(0, "", 2, "dish"),
            new Check(10, "birthday", 3, "dish2")
        };

        var s = new Statistic("Restaurant", checks.ToList());
        Console.WriteLine(s.GetAvgSum());
        Console.WriteLine(s.Visits[0].HasDiscount);
        Console.WriteLine(s.Visits[0].DiscountAmount);
    }
}