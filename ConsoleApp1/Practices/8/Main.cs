using System.Text.RegularExpressions;

namespace ConsoleApp1.Practices._8;

public class Practice8
{
    private static void Task1()
    {
        Console.WriteLine("Enter S A B");
        var s = Convert.ToDouble(Console.ReadLine());
        var a = Convert.ToDouble(Console.ReadLine());
        var b = Convert.ToDouble(Console.ReadLine());

        s -= b;

        var i = 0;
        while (s > 0)
        {
            b *= 1.03;
            s += a - b;
            i++;
        }

        Console.WriteLine($"i -> {i}");
    }

// source http://fb3809fm.bget.ru/_csharp/157.php
    private static int[] GetNums(int end)
    {
        var nums = new List<int>();
        for (var i = 3; i <= end; i++)
        {
            var b = true;
            for (var j = 2; j < i; j++)
            {
                if (i % j == 0 & i % 1 == 0)
                {
                    b = false;
                }
            }

            if (b) nums.Add(i);
        }

        return nums.ToArray();
    }

    private static void Task2()
    {
        Console.WriteLine("Enter i and x");
        var i = Convert.ToInt32(Console.ReadLine());
        var x = Convert.ToDouble(Console.ReadLine());

        var nums = GetNums(i + 1);

        var sum = 0.0;
        for (var j = 1; j <= i; j++)
        {
            sum += Math.Cos(j * 2 * x) / (nums[j - 1] * nums[j]);
        }

        Console.WriteLine(sum);
    }

    private static void Task3()
    {
        for (var x = -Math.PI / 5; x < 6 * Math.PI / 5; x += 0.5)
        {
            var res = x switch
            {
                > 2.5 => 4 * Math.Log(2.3 * x - 1),
                >= 0 and <= 2.5 => 1 + 3 * Math.Sin(Math.Abs(1 - x)),
                < 0 => x * x,
                _ => 0
            };

            Console.WriteLine($"x: {x} - res: {res}");
        }
    }

    private static double[] ReadArray() => Console.ReadLine()!.Split(" ").Select(Convert.ToDouble).ToArray();

    private static void WriteArray(IEnumerable<double> arr) => Console.WriteLine(string.Join(" ", arr));

    private static void Task4()
    {
        Console.WriteLine("Enter array (via space) and c");
        var arr = ReadArray();
        var c = Convert.ToInt32(Console.ReadLine());

        var amount = arr.Count(v => v < c);
        var sum = arr[(Array.FindLastIndex(arr, (v) => v < 0) + 1)..].Sum(v => v % 1 > 0 ? 0 : v);
        var max = arr.Max();
        Array.Sort(arr, (_, b) => b > max * 0.8 ? 1 : -1);

        Console.WriteLine($"amount = {amount}");
        Console.WriteLine($"sum = {sum}");
        WriteArray(arr);
    }

    private static void Task5()
    {
        Console.WriteLine("Enter s");
        var str = Console.ReadLine() ?? "";
        var regex = new Regex(@"\,.*\,");
        str = regex.Replace(str, "");

        Console.WriteLine(str);
    }

    private static void Task6()
    {
        Console.WriteLine("Enter s");
        var words = Console.ReadLine()!.Split(" ");

        Array.Sort(words, string.Compare);
        Console.WriteLine(string.Join(" ", words));
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
                case "5":
                    Task5();
                    break;
                case "6":
                    Task6();
                    break;
                default:
                    return;
            }
        }
    }
}