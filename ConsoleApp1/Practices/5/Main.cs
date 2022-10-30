namespace ConsoleApp1.Practices._5;

public class Practice5
{
    private static int[][] ReadArray()
    {
        Console.WriteLine("Enter array (via space and :)");
        return Console.ReadLine()!.Split(":").Select(a => a.Split(" ").Select(v => Convert.ToInt32(v)).ToArray())
            .ToArray();
    }

    private static void PrintArray(int[][] n)
    {
        Console.WriteLine(string.Join("\n", n.Select(v => string.Join(" ", v))));
    }

    private static void Rotate90(int[][] a)
    {
        var len = a.Length;
        for (var i = 0; i < len / 2; i++)
        {
            for (var j = i; j < len - i - 1; j++)
            {
                var temp = a[i][j];
                a[i][j] = a[len - 1 - j][i];
                a[len - 1 - j][i] = a[len - 1 - i][len - 1 - j];
                a[len - 1 - i][len - 1 - j] = a[j][len - 1 - i];
                a[j][len - 1 - i] = temp;
            }
        }
    }

    private static void Task1()
    {
        var n = ReadArray();

        Rotate90(n);
        Rotate90(n);
        Rotate90(n); // 90 + 90 + 90 = 270

        PrintArray(n);
    }

    private static void Task2()
    {
        var n = ReadArray();
        for (var i = n.Length - 2; i >= 0; i--)
            if (n[0][i] < n[0][i + 1])
                n[0][i] = n[0][i + 1];

        for (var i = 1; i < n.Length; i++)
            if (n[i][n.Length - 1] < n[i - 1][n.Length - 1])
                n[i][n.Length - 1] = n[i - 1][n.Length - 1];

        //9 8 1 0:3 4 5 7:11 9 6 3:2 1 2 3
        for (var i = 1; i < n.Length; i++)
        for (var j = n.Length - 2; j >= 0; j--)
        {
            int[] nearArr = { n[i - 1][j + 1], n[i][j], n[i - 1][j], n[i][j + 1] };
            n[i][j] = nearArr.Max();
        }

        PrintArray(n);
    }

    private static void Task3()
    {
        //9 8 1 0:3 4 5 7:11 9 6 3:2 1 2 3
        var n = ReadArray();

        for (var i = 0; i < n.Length; i++)
        for (var j = 0; j < n.Length; j += 2)
            (n[i][j], n[i][j + 1]) = (n[i][j + 1], n[i][j]);

        PrintArray(n);
    }

    private static void Task4()
    {
        //9 8 1 0:3 4 5 7:11 9 6 3:2 1 2 3
        var n = ReadArray();

        var s = 0;
        var numbers = new int[n.Length * n.Length];
        for (var j = n.Length - 1; j >= 0; j--)
        {
            for (var i = 0; i < n.Length - j; i++)
            {
                numbers[s] = n[i][j + i];
                s++;
            }

            for (var i = 0; i < n.Length - j; i++)
            {
                n[i][j + i] = numbers[..s].Min();
            }
        }

        for (var i = 1; i < n.Length; i++)
        {
            for (var j = 0; j < n.Length - i; j++)
            {
                numbers[s] = n[i + j][j];
                s++;
            }

            for (var j = 0; j < n.Length - i; j++)
            {
                n[i + j][j] = numbers[..s].Min();
            }
        }

        PrintArray(n);
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