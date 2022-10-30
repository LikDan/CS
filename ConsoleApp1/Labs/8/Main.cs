namespace ConsoleApp1.Labs._8;

public class Lab8
{
    private static void Task1()
    {
        Console.WriteLine("Enter date and time");
        var dateTime = DateTime.Parse(Console.ReadLine() ?? DateTime.Today.ToString("g"));

        Console.WriteLine($"Full {dateTime:f}");
        Console.WriteLine($"Short {dateTime:s}");

        var amount = dateTime.ToString("s").Count(c => c == '9');
        Console.WriteLine($"Amount of 9: {amount}");
    }

    private static void Task2()
    {
        Console.WriteLine("Enter bills info (s - stop): ");
        var bills = new List<Bill>();
        while (true)
        {
            var id = Console.ReadLine() ?? "";
            if (id == "s") break;

            var name = Console.ReadLine() ?? "";
            var date = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString("g"));

            if (!Enum.TryParse(Console.ReadLine(), out BillStatus status)) status = BillStatus.NotReady;

            var bill = new Bill(id, name, date, status);
            bills.Add(bill);
        }

        var dateTime = DateTime.Parse(Console.ReadLine() ?? DateTime.Today.ToString("g"));
        var bs = bills.Where(b => b.Datetime.Date == dateTime.Date);
        var res = string.Join("\n", bs.Select(v => v.GetInfo()));
        Console.WriteLine(res);
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
                default:
                    return;
            }
        }
    }
}