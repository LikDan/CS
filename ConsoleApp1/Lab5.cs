int[] ReadArray()
{
    return Console.ReadLine()!.Split(" ").Select(v => Convert.ToInt32(v)).ToArray();
}

void PrintArray<T>(IEnumerable<T> arr)
{
    Console.WriteLine(string.Join(" ", arr));
}

int FindIndex(int[] arr, int el, int count = 0)
{
    for (var i = 0; i < arr.Length; i++)
    {
        if (arr[i] != el) continue;
        if (count == 0) return i;

        count--;
    }

    return 0;
}


int SumArray(int[] arr)
{
    var sum = 0;
    foreach (var i in arr)
    {
        sum += i;
    }

    return sum;
}

void Task1()
{
    Console.WriteLine("Enter array");
    var arr = ReadArray();
    var arr2 = new double[arr.Length];

    for (var i = 0; i < arr.Length; i++)
    {
        arr2[i] = arr[i..].Average();
    }

    PrintArray(arr2);
}

void Task2()
{
    Console.WriteLine("Enter array");
    var arr = ReadArray();
    var i1 = FindIndex(arr, 0);
    var i2 = FindIndex(arr, 0, 1);
    var sum = SumArray(arr[i1..i2]);
    Console.WriteLine($"Sum = {sum}");
}

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
        default:
            return;
    }
}