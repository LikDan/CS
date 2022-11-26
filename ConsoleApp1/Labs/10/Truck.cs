namespace ConsoleApp1.Labs._10;

public class Truck : Vehicle
{
    private double _weight;

    public double Weight
    {
        get => _weight;
        set => _weight = value > 0 ? value : 0;
    }

    public Truck(double price, Wheel wheelType, string model, double weight) : base(price, wheelType, model)
    {
        Weight = weight;
    }

    public override string ToString() => $"{base.ToString()}, Weight: {Weight}";
}