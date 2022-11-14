namespace ConsoleApp1.Practices._11;

public class SmartList<T> : List<T>
{
    private readonly Reflection<T> _reflection;

    public SmartList(Reflection<T> reflection, T[] arr)
    {
        _reflection = reflection;
        AddRange(arr);
    }

    public override string ToString()
    {
        return string.Join("\n", this.Select(v => v.ToString()));
    }

    public void SortBy(string fieldName)
    {
        Sort(_reflection.GetComparator<object>(fieldName));
    }

    public T? MinBy(string fieldName)
    {
        return this.MinBy(_reflection.GetField<object>(fieldName));
    }

    public T? MaxBy(string fieldName)
    {
        return this.MaxBy(_reflection.GetField<object>(fieldName));
    }
}