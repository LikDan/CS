namespace ConsoleApp1.Labs._14;

public class CardsDesk
{
    public delegate void CardDeskHandler(CardsDesk obj, CardDeskEventArgs args);
    public event CardDeskHandler? Event; 
    
    public List<Card> Cards;
    
    private Random _random = new Random();

    public CardsDesk(Card[] cards)
    {
        Event?.Invoke(this, new CardDeskEventArgs("Desk created"));
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
        Event?.Invoke(this, new CardDeskEventArgs("Desk shuffled"));
        Cards = Cards.OrderBy(_ => _random.Next()).ToList();
    }

    public Card[] Pick(int number = 1)
    {
        Event?.Invoke(this, new CardDeskEventArgs("Card picked"));
        var picked = Cards.GetRange(0, number).ToArray();
        Cards.RemoveRange(0, number);
        return picked;
    }
}