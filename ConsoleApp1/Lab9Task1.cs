namespace ConsoleApp1;

public class Lab9Task1
{
    private int[] _arr;

    public Lab9Task1(int[] arr)
    {
        _arr = arr;
    }

    public int[] Arr
    {
        get => _arr;
        set => _arr = value.Where(v => v % 5 == 0).ToArray() ?? throw new ArgumentNullException(nameof(value));
    }

    public int Amount() => _arr.Length;
    public int Sum() => _arr.Sum();
}