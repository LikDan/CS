namespace ConsoleApp1.Labs._10;

public class Vehicle : IComparable<Vehicle>, ICloneable
{
    public Wheel WheelType { get; set; }

    public String Model { get; set; }

    private double _price;

    public double Price
    {
        get => _price;
        set => _price = value > 0 ? value : 0;
    }

    public Vehicle(double price, Wheel wheelType, string model)
    {
        Price = price;
        WheelType = wheelType;
        Model = model;
    }

    public Vehicle()
    {
        WheelType = new Wheel();
        Model = "";
    }

    public override string ToString() => $"Model: {Model}, Price: {Price}, WheelType: {WheelType}";

    public object Clone() => new Vehicle(Price, WheelType, Model);

    public int CompareTo(Vehicle? obj) => Price.CompareTo(obj?._price);


    public static Vehicle? FindCheapestByModel(Vehicle[] vehicles, String model)
    {
        return vehicles.Where(vehicle => vehicle.Model == model).MinBy(vehicle => vehicle._price);
    }
}