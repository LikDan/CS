namespace ConsoleApp1.Practices._9;

struct Person
{
    public string Firstname;
    public string Lastname;
    public int[] Birthday;
    public string Sign;

    public Person(string firstname, string lastname, int[] birthday, string sign)
    {
        Firstname = firstname;
        Lastname = lastname;
        Birthday = birthday;
        Sign = sign;
    }

    public DateOnly GetBirthday() => DateOnly.Parse($"{Birthday[0]}/{Birthday[1]}/{Birthday[2]}");
    
    public override string ToString() => $"Name: {Firstname} {Lastname}, Birthday {string.Join(" ", Birthday)}, Zodiac: {Sign}";
    
    public static Person Parse(string str)
    {
        var arr = str.Split(" ");
        var birthday = arr[2..5].Select(v => Convert.ToInt32(v)).ToArray();

        return new Person(arr[0], arr[1], birthday, arr[5]);
    }
}