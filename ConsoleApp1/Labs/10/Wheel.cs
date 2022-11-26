namespace ConsoleApp1.Labs._10;

public class Wheel
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set => _radius = value > 0 ? value : 0;
    }

    public Wheel()
    {
    }

    public Wheel(double radius)
    {
        _radius = radius;
    }

    public override string ToString()
    {
        return $"Radius {_radius}";
    }
}