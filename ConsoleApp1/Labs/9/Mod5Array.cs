namespace ConsoleApp1.Labs._9;

public class Mod5Array
{
    private int[] _arr;

    public Mod5Array(int[] arr)
    {
        Arr = arr;
    }

    public int[] Arr
    {
        get => _arr;
        set => _arr = value.Where(v => v % 5 == 0).ToArray() ?? throw new ArgumentNullException(nameof(value));
    }

    public int Amount()
    {
        return _arr.Length;
    }

    public int Sum()
    {
        return _arr.Sum();
    }
}