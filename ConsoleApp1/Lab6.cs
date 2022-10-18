using System.Text;

void Task1()
{
    Console.WriteLine("Enter text");
    var text = Console.ReadLine()?.Trim() ?? "";

    var res = text[0].ToString();
    for (var i = 1; i < text.Length; i++)
        if (text[i] != ' ' || text[i - 1] != ' ')
            res += text[i];
    
    Console.WriteLine(res);

    res = string.Join(" ", text.Split(' ').Where(v => v != ""));
    Console.WriteLine(res);

    var builder = new StringBuilder();
    foreach (var s in text.Split(' ').Where(v => v != ""))
    {
        builder.Append(s);
        builder.Append(' ');
    }

    builder.Length--;
    res = builder.ToString();
    
    Console.WriteLine(res);
}

void Task2()
{
    Console.WriteLine("Enter numbers");
    var nums = Console.ReadLine()!.Split(" ").Select(v => Convert.ToInt32(v)).ToArray();
    var num1 = nums[0];
    var num2 = nums[1];

    var res = num1 * num2;
    Console.WriteLine(String.Format("{0:E}*{1:E}={2:E}", num1, num2, res));
    Console.WriteLine("{0:E}*{1:E}={2:E}", num1, num2, res);
    Console.WriteLine($"{num1:E}*{num2:E}={res:E}");
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