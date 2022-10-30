namespace ConsoleApp1.Labs._1;

public class Lab1
{
    public static void Launch()
    {
        Console.WriteLine("Task1");

        var x = 37.4;
        var y = 0.825;
        var z = 1.6;

        var p1 = 1 + Math.Pow(Math.Sin(x + y), 2);
        var p2 = Math.Abs(x - 2 * y / (1 + x * x * y * y));
        var p3 = Math.Pow(x, Math.Abs(y));
        var p4 = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

        var res = p1 / p2 * p3 + p4;
        Console.WriteLine(res);

        Console.WriteLine("Task2");

        Console.WriteLine($"Before x:{x}, y:{y}");
        (x, y) = (y, x);
        Console.WriteLine($"After x:{x}, y:{y}");
    }
}