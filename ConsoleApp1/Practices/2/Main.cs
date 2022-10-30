namespace ConsoleApp1.Practices._2;

public class Practice2
{
    static void Task1()
    {
        Console.WriteLine("Enter a, b, c");

        var a = Convert.ToDouble(Console.ReadLine());
        var b = Convert.ToDouble(Console.ReadLine());
        var c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"a = {a}, b = {b}, c = {c}");

        var times = -1;

        if (a < b && b < c || a > b && b > c) times = 2;

        a *= times;
        b *= times;
        c *= times;

        Console.WriteLine($"a = {a}, b = {b}, c = {c}");
    }

    static void RadiusTask2(double r)
    {
        var d = r * 2;
        var l = d * Math.PI;
        var s = Math.PI * r * r;

        Console.WriteLine($"Radius = {r}, Diameter = {d}, Length = {l}, Square = {s}");
    }

    static void Task2()
    {
        Console.WriteLine("Enter action");
        var action = Console.ReadLine();
        Console.WriteLine("Enter value");
        var value = Convert.ToDouble(Console.ReadLine());
        switch (action)
        {
            case "1":
                RadiusTask2(value);
                break;
            case "2":
                RadiusTask2(value / 2);
                break;
            case "3":
                RadiusTask2(value / (2 * Math.PI));
                break;
            case "4":
                RadiusTask2(Math.Sqrt(value / Math.PI));
                break;
            default:
                Console.WriteLine("Bad action");
                break;
        }
    }

    static void Task3()
    {
        Console.WriteLine("Enter action (sh, x, e)");
        var action = Console.ReadLine();
        Console.WriteLine("Enter y");
        var x = Convert.ToDouble(Console.ReadLine());
        var y = Convert.ToDouble(Console.ReadLine());

        var fx = 0.0;

        switch (action)
        {
            case "sh":
                fx = Math.Sinh(x);
                Console.WriteLine($"sh(x): {fx}");
                break;
            case "x":
                fx = x * x;
                Console.WriteLine($"x^2: {fx}");
                break;
            case "e":
                fx = Math.Pow(Math.E, x);
                Console.WriteLine($"e^x: {fx}");
                break;
            default:
                Console.WriteLine("Bad action");
                return;
        }

        var z = 0.0;
        switch (y)
        {
            case > -1:
                z = Math.Pow(Math.Abs(x), 4) * fx * fx / (y + 1);
                break;
            case < -1:
                z = Math.Cos(Math.Abs(fx * fx * fx)) + Math.Sin(Math.Abs(y));
                break;
            default:
                z = Math.Sqrt(Math.Abs(Math.Pow(Math.Tan(fx), 2)));
                break;
        }

        Console.WriteLine($"Z = {z}");
    }

    static void Task4()
    {
        Console.WriteLine("Enter x");
        var x = Convert.ToDouble(Console.ReadLine());
        const double r = 2.0;

        switch (x)
        {
            case <= -7:
            case >= 3:
            case -6:
                Console.WriteLine("Bad value");
                break;
            case -2:
                Console.WriteLine("Y = 2");
                break;
            case > -7 and < -6:
                Console.WriteLine($"Y = {r}");
                break;
            case > -6 and < -2:
                var xSize = (x + 2) * -1;
                var ySize = (xSize / 4) * 1;

                Console.WriteLine($"Y = -{ySize}");
                break;
            case > -2 and < 0:
                var angle1 = Math.Acos((x * -1) / r);
                var y2 = r - r * Math.Sin(angle1);

                Console.WriteLine($"Y = {y2}");
                break;
            case > 0 and < 2:
                var angle = Math.Acos(x / r);
                var y1 = r * Math.Sin(angle);

                Console.WriteLine($"Y = {y1}");
                break;
            case > 2 and < 3:
                var y = (x - 2) * -1;
                Console.WriteLine($"Y = {y}");
                break;
        }
    }

    public static void Launch()
    {
        while (true)
        {
            Console.WriteLine("Enter task #");
            var action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                default:
                    return;
            }
        }
    }
}