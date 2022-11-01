namespace ConsoleApp1.Practices._9;

public class Practice9
{
    public static void Launch()
    {
        var persons = new List<Person>();

        Console.WriteLine("Enter person");
        while (true)
        {
            var s = Console.ReadLine() ?? "";
            if (s == "") break;

            persons.Add(Person.Parse(s));
        }

        persons.Sort((p1, p2) => p1.GetBirthday().CompareTo(p2.GetBirthday()));
        Console.WriteLine(string.Join("\n", persons.Select(p => p.ToString())));

        Console.WriteLine("---------------------------\nEnter zodiac sign");

        var sign = Console.ReadLine();

        persons = persons.Where(p => p.Sign == sign).ToList();
        if (persons.Count == 0)
        {
            Console.WriteLine("No elements");
            return;
        }

        Console.WriteLine(string.Join("\n", persons.Select(p => p.ToString())));
    }
}