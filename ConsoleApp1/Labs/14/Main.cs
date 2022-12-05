namespace ConsoleApp1.Labs._14;

public class Lab14
{
    public static void Log(object _, CardDeskEventArgs args) => Console.WriteLine(args.Message);
    
    public static void Launch()
    {
        try
        {
            var desk = new CardsDesk(new[]
            {
                new Card("Hearts", "10"),
                new Card("Hearts", "10"),
                new Card("Hearts", "2"),
                new Card("Hearts", "4"),
                new Card("Hearts", "3"),
                new Card("Hearts", "5"),
                new Card("Hearts", "6"),
            });

            desk.Event += Log;
            
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