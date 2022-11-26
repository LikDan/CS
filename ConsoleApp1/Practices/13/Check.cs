using ConsoleApp1.Labs._12;

namespace ConsoleApp1.Practices._13;

public class Check
{
    private double _discountAmount;
    private string? _discountType;


    public bool HasDiscount => DiscountType != null;

    public string? DiscountType
    {
        get => _discountType;
        set => _discountType = value?.ToTitleCase();
    }

    public double DiscountAmount
    {
        get => _discountAmount;
        set => _discountAmount = value > 0 ? value : throw new MyException("DiscountAmount Exception");
    }

    public List<string> Dishes { get; private set; }

    public void AddDish(string dish)
    {
        if (Dishes.Count < 500) throw new MyException("A lot of dishes");
        Dishes.Add(dish);
    }

    public Check(double discountAmount, string? discountType, List<string> dishes)
    {
        DiscountAmount = discountAmount;
        DiscountType = discountType;
        Dishes = dishes;
    }

    public Check(double discountAmount, string? discountType, string dish)
    {
        DiscountAmount = discountAmount;
        DiscountType = discountType;
        Dishes = new List<string>();
        
        AddDish(dish);
    }

    public override string ToString() => $"{DiscountType}, {DiscountAmount}, {Dishes.Count}";
}