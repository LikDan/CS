namespace ConsoleApp1.Labs._12;

public class CardsDesk
{
    public List<Card> Cards = new();
    
    private Random _random = new Random();

    public CardsDesk(Card[] cards)
    {
        Cards = cards.ToList();
    }
    
    public Card GetCardByIndex(int i)
    {
        return Cards[i];
    }

    public string GetCardsInfo()
    {
        return string.Join(", ", Cards.Select(card => card.ToString()));
    }

    public void Shuffle()
    {
        Cards = Cards.OrderBy(_ => _random.Next()).ToList();
    }

    public Card[] Pick(int number = 1)
    {
        var picked = Cards.GetRange(0, number).ToArray();
        Cards.RemoveRange(0, number);
        return picked;
    }
}