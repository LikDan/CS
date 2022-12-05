namespace ConsoleApp1.Labs._13;

public class Lab13
{
    public delegate double Calc(double value);

    
    public static void Print(double min, double max, double step, Calc calc)
    {
        for (var i = min; i < max; i += step)
        {
            var res = calc(i);
            Console.WriteLine(res);
        }
    }
    
    public static void Launch()
    {
        Console.WriteLine("\n\n*****Sinh*****\n");
        Print(-2, 0, 0.03, Math.Sinh);
        Console.WriteLine("\n\n*****Sin*****\n");
        Print(-2, 0, 0.03, Math.Sin);
    }
}