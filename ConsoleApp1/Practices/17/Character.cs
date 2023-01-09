namespace ConsoleApp1.Practices._17;

public class Character: IComparable<Character>
{
    public string Name { get; set; }
    public string Ability { get; set; }
    public uint HP { get; set; }

    public string State =>
        HP switch
        {
            0 => "Dead",
            _ => "Alive"
        };

    public Character(string name, string ability, uint hp)
    {
        Name = name;
        Ability = ability;
        HP = hp;
    }

    public int CompareTo(Character? other) => Convert.ToInt32(HP) - Convert.ToInt32(other?.HP);

    public override string ToString() => $"\nName: {Name}, Ability: {Ability}, HP: {HP}, State: {State}";
}