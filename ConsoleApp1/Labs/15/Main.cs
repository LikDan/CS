using CalculationLibrary;

namespace ConsoleApp1.Labs._15;

public class Lab15
{
    public static void Launch()
    {
        var c = new Calculation(10, 20, 13, 17, 5);
        Console.WriteLine(c.TrapezoidSquare);
        Console.WriteLine(c.CircleSquare);
    }
}