class Program {
    static void Main(string[] args)
    {
        MonopolyGameController monopoly = new MonopolyGameController(5);
        monopoly.AddCards(new BirthdayCard("birthday1", "yellow", 1));
        monopoly.AddCards(new JailCard("jail1", "red", 2));
    }
}

class MonopolyGameController {
    private Card[] _cards;
    private int _count = 0;

    public MonopolyGameController(int cardAmount) {
        _cards = new Card[cardAmount];
    }
    public bool AddCards(Card card) {
        if (_count < _cards.Length) {
            _cards[_count] = card;
            _count++;
            return true;
        }
        return false;
    }

}

abstract class Card {
    private string _name;
    private string _colour;
    private int _id;

    public string GetName() {
        return _name;
    }
    public string GetColour() {
        return _colour;
    }
    public int GetId() {
        return _id;
    }

    public Card(string name, string colour, int id) {
        _name = name;
        _colour = colour;
        _id = id;
    }

    public abstract void StartEffect();
}

class BirthdayCard : Card {
    public BirthdayCard(string name, string colour, int id) : base(name, colour, id) {

    }
    public override void StartEffect()
    {
        Console.WriteLine("BirthdayCard effect started");
    }
}

class JailCard : Card {
    public JailCard(string name, string colour, int id) : base(name, colour, id) {

    }
    public override void StartEffect()
    {
        Console.WriteLine("JailCard effect started");
    }
}