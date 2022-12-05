namespace ConsoleApp1.Labs._14;

public class Card
{
    public static readonly string[] Suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
    public static readonly string[] Numbers = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "V", "D", "K", "T" };

    private string _suit;

    public string Suit
    {
        get => _suit;
        set => _suit = Suits.Contains(value) ? value : throw new Exception("Bad suit");
    }

    private string _number;

    public string Number
    {
        get => _number;
        set => _number = Numbers.Contains(value) ? value : throw new Exception("Bad number");
    }

    public Card(string suit, string number)
    {
        Suit = suit;
        Number = number;
    }

    public override string ToString() => $"Suit: {Suit}, Number: {Number}";
}