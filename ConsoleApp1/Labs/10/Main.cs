namespace ConsoleApp1.Labs._10;

public class Lab10
{

    public static void Launch()
    {
        var calls = new DayPhoneCalls();
        calls.AddCall(new PhoneCall(10, 3.123));
        calls.AddCall(new PhoneCall(1, 3.177));
        calls.AddCall(new PhoneCall(5, 3.7));
        
        Console.WriteLine(calls.Amount());
        Console.WriteLine(calls.TotalMinutes());
        Console.WriteLine(calls.TotalSum());


        var vehicles = new[]
        {
            new Vehicle(20, new Wheel(19), "Ford"),
            new Vehicle(20, new Wheel(19), "Ford2"),
            new Vehicle(2, new Wheel(19), "Ford"),
            new Truck(1, new Wheel(19), "Ford", 10)
        };
        
        Console.WriteLine(Vehicle.FindCheapestByModel(vehicles, "Ford"));
    }
}