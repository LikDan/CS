namespace ConsoleApp1.Practices._11;

public class Reflection<TF> : IReflection<TF>
{
    public T GetFiledByName<T>(string name, TF obj)
    {
        return (T)typeof(TF).GetProperty(name)!.GetValue(obj)!;
    }

    public int CompareByFieldName<T>(string name, TF first, TF second)
    {
        return CField<T>(name, first).CompareTo(CField<T>(name, second));
    }

    public Func<TF, T> GetField<T>(string fieldName)
    {
        return w1 => GetFiledByName<T>(fieldName, w1);
    }

    public Comparison<TF> GetComparator<T>(string fieldName)
    {
        return (w1, w2) => CompareByFieldName<T>(fieldName, w1, w2);
    }

    private IComparable CField<T>(string name, TF obj)
    {
        return (IComparable)GetFiledByName<T>(name, obj)!;
    }
}