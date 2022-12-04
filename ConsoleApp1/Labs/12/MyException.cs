namespace ConsoleApp1.Labs._12;

public class MyException: Exception
{
    // private string _msg { get; set; }
    //
    // public override string Message
    // {
    //     get => _msg;
    // }

    public MyException(string? message) : base(message)
    {
    }
}