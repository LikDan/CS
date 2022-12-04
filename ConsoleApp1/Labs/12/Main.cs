namespace ConsoleApp1.Labs._12;

public class Lab12
{
    public static void Launch()
    {
        try
        {
            var a = Convert.ToInt32(Console.ReadLine() ?? "0");
            var b = Convert.ToInt32(Console.ReadLine() ?? "0");
            var c = Convert.ToInt32(Console.ReadLine() ?? "0");

            var m = Math.Sqrt((2 * a * a + 2 * b * b - c * c) / 4.0);

            if (a > b + c || b > a + c || c > a + b)
                throw new ArgumentException($"WTF is triangle doesn't exists, but in case median eq {m}");

            Console.WriteLine(m);
            Console.WriteLine(a + b + c);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Console.WriteLine("Enter array (via space and :)");
            var matrix = Console.ReadLine()!.Split(":")
                .Select(a => a.Split(" ")
                    .Select(v => Convert.ToInt32(v))
                    .ToArray()).ToArray();

            var min = matrix.Select((l, i) => Math.Abs(l[matrix.Length - i - 1])).Min();
            Console.WriteLine(min);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            var desk = new CardsDesk(new[]
            {
                new Card("Hearts", "10"),
                new Card("Hearts", "1"),
                new Card("Hearts", "2"),
                new Card("Hearts", "4"),
                new Card("Hearts", "3"),
                new Card("Hearts", "5"),
                new Card("Hearts", "6"),
            });

            Console.WriteLine(desk.GetCardsInfo());
            desk.Shuffle();
            Console.WriteLine(desk.GetCardsInfo());

            Console.WriteLine(string.Join(", ", desk.Pick().Select(c => c.ToString())));
            Console.WriteLine(desk.GetCardsInfo());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}