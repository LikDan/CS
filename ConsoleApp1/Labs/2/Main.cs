namespace ConsoleApp1.Labs._2;

public class Lab2
{
    public static void Launch()
    {
        var x = Convert.ToDouble(Console.ReadLine());

        var part1 = x * x - 5 * Math.Sqrt(2);
        var part2 = 2 * x * x * x + 1;

        var y = part1 / part2;
        Console.WriteLine($"y: {y}");
    }
}