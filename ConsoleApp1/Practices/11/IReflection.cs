namespace ConsoleApp1.Practices._11;

public interface IReflection<TF>
{
    T GetFiledByName<T>(string name, TF obj);
    int CompareByFieldName<T>(string name, TF first, TF second);
    Func<TF, T> GetField<T>(string fieldName);
    Comparison<TF> GetComparator<T>(string fieldName);
}