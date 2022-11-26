namespace ConsoleApp1.Labs._11;

public class Flat: IComparable<Flat>, ICloneable
{
    private string _address;
    private double _size;
    private uint _roomAmount;

    public string Address
    {
        get => _address;
        set => _address = value.Length > 5 ? value : "UNKNOWN";
    }

    public double Size
    {
        get => _size;
        set => _size = value > 0 ? value : 0;
    }

    public uint RoomAmount
    {
        get => _roomAmount;
        set => _roomAmount = value is > 0 and < 100 ? value : 1;
    }

    public Flat()
    {
        Address = "";
    }

    public Flat(string address, double size, uint roomAmount)
    {
        Address = address;
        Size = size;
        RoomAmount = roomAmount;
    }

    public override string ToString() => $"{Address} ({Size}m) -> {RoomAmount} rooms";
    public object Clone() => new Flat(Address, Size, RoomAmount);

    public int CompareTo(Flat? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var sizeComparison = Size.CompareTo(other.Size);
        if (sizeComparison != 0) return sizeComparison;
        var addressComparison = string.Compare(Address, other.Address, StringComparison.Ordinal);
        if (addressComparison != 0) return addressComparison;
        return RoomAmount.CompareTo(other.RoomAmount);
    }
}