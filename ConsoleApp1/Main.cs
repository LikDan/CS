namespace ConsoleApp1;

public class ConsoleApp1
{
    private static readonly string NS = "ConsoleApp1";
    private static readonly string MD = "Launch";

    private static void PrintDivider(string prompt) =>
        Console.WriteLine($"\n{new string('-', 5)}{prompt}{new string('-', 5)}\n");

    private static bool Invoke(string typeName)
    {
        try
        {
            return Type.GetType($"{NS}.{typeName}, {NS}")?.GetMethod(MD)?.Invoke(null, null) == null;
        }
        catch (Exception e)
        {
            PrintDivider("Execution exception");
            Console.WriteLine(e);
        }

        return false;
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter task using pattern (L|P)# or s to stop");
            var line = Console.ReadLine();
            if (line == "s") break;

            if (line == null || line.Length < 2)
            {
                PrintDivider("Bad data");
                continue;
            }

            var type = line[0] switch
            {
                'P' or 'p' => "Practice",
                'L' or 'l' => "Lab",
                _ => "?"
            };

            if (!Invoke($"{type}s._{line[1..]}.{type}{line[1..]}")) PrintDivider("Failed to invoke");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}