namespace CalculationLibrary;

public class Calculation
{
    private double _a;
    private double _b;
    private double _c;
    private double _d;
    private double _r;

    public double A
    {
        get => _a;
        private set => _a = value > 0 ? value : throw new ArgumentException("Less than 0");
    }

    public double B
    {
        get => _b;
        private set => _b = value > 0 ? value : throw new ArgumentException("Less than 0");
    }

    public double C
    {
        get => _c;
        private set => _c = value > 0 ? value : throw new ArgumentException("Less than 0");
    }

    public double D
    {
        get => _d;
        private set => _d = value > 0 ? value : throw new ArgumentException("Less than 0");
    }

    public double R
    {
        get => _r;
        private set => _r = value > 0 ? value : throw new ArgumentException("Less than 0");
    }

    public Calculation(double a, double b, double c, double d, double r)
    {
        if (a + b != c + d) throw new ArgumentException("Bad sides");

        A = a;
        B = b;
        C = c;
        D = d;
        R = r;
    }

    private double TrapezoidPerimeter => A + B + C + D;
    public double TrapezoidSquare => R * (TrapezoidPerimeter / 2);
    public double CircleSquare => Math.PI * R * R;
}