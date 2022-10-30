
namespace ConsoleApp1.Practices._4;

public class Practice4
{
    private static void Task1()
    {
        Console.WriteLine("Enter array (via space)");
        var n = Console.ReadLine()?.Split(" ").Select(a => Convert.ToInt32(a)).ToArray();
        if (n == null) return;

        var maxIndex = Array.IndexOf(n, n.Max());
        var minIndex = Array.IndexOf(n, n.Min());

        var sum = n[minIndex..maxIndex].Sum();
        Console.WriteLine($"Sum is {sum}");
    }

    private static void Task2()
    {
        Console.WriteLine("Enter array (via space)");
        var n = Console.ReadLine()?.Split(" ").Select(a => Convert.ToInt32(a)).ToArray();
        if (n == null) return;

        var evenLen = n.Where(v => v % 2 == 0).ToArray().Length;
        var oddLen = n.Where(v => v % 2 == 1).ToArray().Length;

        Console.WriteLine(oddLen > evenLen ? "Odd" : "Even");
    }

    private static void Task3()
    {
        Console.WriteLine("Enter array (via space)");
        Console.WriteLine(string.Join(" ", Console.ReadLine()!.Split(" ").Select(a => Convert.ToInt32(a)).Reverse()));
    }

    private static void Task4()
    {
        Console.WriteLine("Enter array (via space)");
        var n = Console.ReadLine()?.Split(" ").Select(a => Convert.ToInt32(a)).ToArray();
        if (n == null) return;

        Console.WriteLine("Enter number");
        var num = Convert.ToInt32(Console.ReadLine());

        var min = n.MinBy(v => Math.Abs(v - num));
        Console.WriteLine($"Min: {min}");
    }

    private static void Task5()
    {
        Console.WriteLine("Enter array (via space)");
        var n = Console.ReadLine()?.Split(" ").Select(a => Convert.ToInt32(a)).ToArray();
        if (n == null) return;
        n = n[(n.Length / 2)..].Concat(n[..(n.Length / 2)]).ToArray();

        Console.WriteLine(string.Join(" ", n));
    }

//source: https://vscode.ru/prog-lessons/sortirovka-metodom-vyibora-c-sharp.html
    private static int[] Sort(int[] mas)
    {
        for (var i = 0; i < mas.Length - 1; i++)
        {
            var min = i;
            for (var j = i + 1; j < mas.Length; j++)
                if (mas[j] < mas[min])
                    min = j;

            (mas[min], mas[i]) = (mas[i], mas[min]);
        }

        return mas;
    }

    private static void Task6()
    {
        Console.WriteLine("Enter array (via space)");
        var n = Console.ReadLine()?.Split(" ").Select(a => Convert.ToInt32(a)).ToArray();
        if (n == null) return;

        Console.WriteLine(string.Join(" ", Sort(n)));
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