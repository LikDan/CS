using ConsoleApp1.Labs._12;

namespace ConsoleApp1.Practices._14;

public class Check
{
    public delegate void CardDeskHandler(object? o, CheckEventArgs args);
    public event CardDeskHandler? Event;
    
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
        set => _discountAmount = value >= 0 ? value : throw new MyException("DiscountAmount Exception");
    }

    private double _price;

    public double Price
    {
        get => _price;
        set => _price = value < 1000 ? value : throw new Exception("Price Exception");
    }

    public List<string> Dishes { get; private set; }

    public void AddDish(string dish)
    {
        if (Dishes.Count >= 500) throw new MyException("A lot of dishes");
        Event?.Invoke(this, new CheckEventArgs("AddDish"));
        Dishes.Add(dish);
    }

    public Check(double discountAmount, string? discountType, double price, List<string> dishes)
    {
        if (dishes.Count == 0) throw new MyException("Where is dishes");

        DiscountAmount = discountAmount;
        DiscountType = discountType;
        Price = price;
        Dishes = dishes;
    }

    public Check(double discountAmount, string? discountType, double price, string dish)
    {
        DiscountAmount = discountAmount;
        DiscountType = discountType;
        Price = price;
        Dishes = new List<string>();
        
        AddDish(dish);
    }

    public override string ToString() => $"{DiscountType}, {DiscountAmount}, {Dishes.Count}";
}