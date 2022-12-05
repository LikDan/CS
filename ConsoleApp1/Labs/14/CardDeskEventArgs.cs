namespace ConsoleApp1.Labs._14;

public class CardDeskEventArgs: EventArgs
{
    public string Message { get; set; }

    public CardDeskEventArgs(string message)
    {
        Message = message;
    }
}