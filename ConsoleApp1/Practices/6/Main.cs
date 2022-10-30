namespace ConsoleApp1.Practices._6;

public class Practice6
{
    private static int ToInt(string s) => Convert.ToInt32(s);
    private static void Print(string s) => Console.WriteLine(s);
    private static string Read() => Console.ReadLine()!;

    private static string EnterArrayViaSpaceText() => "Enter array (via space)";
    private static void WriteEnterArrayViaSpace() => Print(EnterArrayViaSpaceText());

    private static string GetSpaceText() => " ";
    private static IEnumerable<string> ReadLineAndSplitSpaces() => Read().Split(GetSpaceText());
    private static IEnumerable<int> ReadLineSplitSpacesAndConvertToInt() => ReadLineAndSplitSpaces().Select(ToInt);
    private static int[] ReadLineSplitSpacesAndConvertToIntArray() => ReadLineSplitSpacesAndConvertToInt().ToArray();

    private static int[] WriteEnterArrayViaSpaceAndReadLineSplitSpacesAndConvertToIntArray()
    {
        WriteEnterArrayViaSpace();
        return ReadLineSplitSpacesAndConvertToIntArray();
    }

    private static int GetNumberToDivideToGetHalf() => 2;
    private static int GetHalf(int num) => num / GetNumberToDivideToGetHalf();
    private static int GetArrayLenght(int[] arr) => arr.Length;
    private static int GetHalfOfArrayLength(int[] arr) => GetHalf(GetArrayLenght(arr));

    private static int[] SliceArrayAfterHalf(int[] arr) => arr[GetHalfOfArrayLength(arr)..];
    private static int[] SliceArrayBeforeHalf(int[] arr) => arr[..GetHalfOfArrayLength(arr)];

    private static IEnumerable<int> ConcatArraysToEnumerable(int[] arr1, int[] arr2) => arr1.Concat(arr2);

    private static IEnumerable<int> ConcatBeforeHalfAndAfterHalfToEnumerable(int[] arr) =>
        ConcatArraysToEnumerable(SliceArrayAfterHalf(arr), SliceArrayBeforeHalf(arr));

    private static IEnumerable<int>
        WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayAndConcatBeforeHalfAndAfterHalfToEnumerable() =>
        ConcatBeforeHalfAndAfterHalfToEnumerable(WriteEnterArrayViaSpaceAndReadLineSplitSpacesAndConvertToIntArray());

    private static string JoinEnumerableThroughSpace(IEnumerable<int> arr) => string.Join(GetSpaceText(), arr);

    private static string
        WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayConcatBeforeHalfAndAfterHalfToEnumerableAndJoinThroughSpace() =>
        JoinEnumerableThroughSpace(
            WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayAndConcatBeforeHalfAndAfterHalfToEnumerable());

    private static void
        WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayConcatBeforeHalfAndAfterHalfToEnumerableJoinThroughSpaceAndPrint() =>
        Print(
            WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayConcatBeforeHalfAndAfterHalfToEnumerableAndJoinThroughSpace());

    private static void Task1() =>
        WriteEnterArrayViaSpaceReadLineSplitSpacesAndConvertToIntArrayConcatBeforeHalfAndAfterHalfToEnumerableJoinThroughSpaceAndPrint();


    private static void Task2()
    {
        var arr = WriteEnterArrayViaSpaceAndReadLineSplitSpacesAndConvertToIntArray();
        Array.Sort(arr);

        Console.WriteLine(string.Join(" ", arr.Reverse().ToArray()[..3].Reverse()));
    }

    private static void MinMax(ref int x, ref int y)
    {
        if (x < y) return;
        (x, y) = (y, x);
    }

    private static void Task3()
    {
        Print("Enter 4 symbols (via space)");
        var arr = ReadLineSplitSpacesAndConvertToIntArray();
        var (n1, n2, n3, n4) = (arr[0], arr[1], arr[2], arr[3]);

        MinMax(ref n1, ref n2);
        MinMax(ref n3, ref n4);

        MinMax(ref n1, ref n3);
        MinMax(ref n2, ref n4);

        Console.WriteLine($"{n1} {n4}");
    }

    private static double Arctg1(double x, double e)
    {
        var sum = 0.0;
        var temp = x;
        var i = 1;
        while (Math.Abs(temp) < e)
        {
            sum += temp;
            temp = Math.Pow(-1, i) * Math.Pow(x, i * 2 + 1) / i * 2 + 1;
            i++;
        }

        return sum;
    }

    private static void Task4()
    {
        Console.WriteLine("Enter x and e(s)");
        var x = Convert.ToDouble(Console.ReadLine());
        var es = ReadLineAndSplitSpaces().Select(Convert.ToDouble);
        foreach (var e in es)
        {
            var res = Arctg1(x, e);
            Console.WriteLine(res);
        }
    }

    private static double Task5Bigger0(int n, double x)
    {
        if (n == 0) return 1;

        return Math.Pow(x, n) * Task5Bigger0(n - 1, x);
    }

    private static void Task5()
    {
        Console.WriteLine("Enter x and n");
        var x = Convert.ToDouble(Console.ReadLine());
        var n = Convert.ToInt32(Console.ReadLine());

        var result = n switch
        {
            < 0 => 1 / Math.Pow(x, -n),
            0 => 1,
            > 0 => Task5Bigger0(n, x),
        };

        Console.WriteLine(result);
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
                default:
                    return;
            }
        }
    }
}