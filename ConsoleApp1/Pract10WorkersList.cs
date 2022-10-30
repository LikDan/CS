public class Pract10WorkersList : List<Pract10Worker>
{
    public Pract10WorkersList(Pract10Worker[] arr) => AddRange(arr);

    public override string ToString() => string.Join("\n", this.Select(v => v.ToString()));

    public void SortBy(string fieldName) => Sort(GetComparator<object>(fieldName));

    public Pract10Worker? MinBy(string fieldName) => this.MinBy(GetField<object>(fieldName));
    public Pract10Worker? MaxBy(string fieldName) => this.MaxBy(GetField<object>(fieldName));

    private static Comparison<Pract10Worker> GetComparator<T>(string fieldName) =>
        (w1, w2) => w1.CompareByFieldName<T>(fieldName, w2);
    
    private static Func<Pract10Worker, T> GetField<T>(string fieldName) =>
        w1 => w1.GetFiledByName<T>(fieldName);
}