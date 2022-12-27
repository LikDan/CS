namespace ConsoleApp1.Practices._16;

public class WorkerEventArgs: EventArgs
{
    public WorkerEventArgs(string message)
    {
        Message = message;
    }

    public string Message { get; set; }
}