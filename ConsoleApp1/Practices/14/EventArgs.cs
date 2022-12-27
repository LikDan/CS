namespace ConsoleApp1.Practices._14;

public class CheckEventArgs: EventArgs
{
    public CheckEventArgs(string message)
    {
        Message = message;
    }

    public string Message { get; set; }
}