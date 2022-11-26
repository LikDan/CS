namespace ConsoleApp1.Labs._10;

public class PhoneCall
{
    private double _length;

    public double Length
    {
        get => _length;
        set => _length = value > 0 ? value : 0;
    }

    private double _pricePerMinute;

    public double PricePerMinute
    {
        get => _pricePerMinute;
        set => _pricePerMinute = value > 0 ? value : 0;
    }

    public double TotalSum() => Length * PricePerMinute;

    public PhoneCall(double pricePerMinute, double length)
    {
        PricePerMinute = pricePerMinute;
        Length = length;
    }
}