using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFishing
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            //Konstruktor tworzy 52 karty
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            //Przeciążony konstruktor przyjmuje jeden parametr - tablicę kart
            //które wczytywane są do początkowego zestawu
            cards = new List<Card>(initialCards);
        }

        public int Count
        {
            get
            {
                return cards.Count;
            }
        }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle()
        {
            List<Card> NewCards = new List<Card>();
            while (cards.Count > 0)
            {
                int CardsToMove = random.Next(cards.Count);
                NewCards.Add(cards[CardsToMove]);
                cards.RemoveAt(CardsToMove);
            }
            cards = NewCards;
            //Metoda tasuje karty, ustawiając je w losowej kolejności
        }

        public IEnumerable<string> GetCardsNames()
        {
            //ta metoda zwraca tablicę łańcuchów znaków zawierającą nazwę każdej karty
            string[] cardsToName = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
            {
                cardsToName[i] = cards[i].Name;
            }
            return cardsToName;
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }

        //nowe metody

        public Card Peek(int cardNumber)
        {
            //metoda pozwala obejrzeć jedną kartę bez pobierania
            return cards[cardNumber];
        }

        public Card Deal()
        {
            //Jeżeli nie zostanie przekazany tej mietodzie żadnych parametrów
            //będzie pobierana karta z wierzchu talii
            return Deal(0);
        }

        public bool ContainsValues(Values value)
        {
            //metod przeszukuje cały zestaw kartpod kątem okreśkonej wartości i zwraca true,
            //jeżeli taką znajdzie
            foreach (Card card in cards)
                if (card.Value == value)
                    return true;
            return false;
        }

        public Deck PullOutValues(Values value)
        {
            //metoda będzie używana podczas pobierania grupy kart z zestawu
            //wyszukuje ona każdą kartę, która posiada taką samą wartość
            //jak przekazywany parametr, wyciąga ją z zestawu i zwraca nowy zestaw
            //zawierający takie własnie karty
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }

        public bool HasBook(Values value)
        {
            //metoda sprawdza, czy zestaw posiada grupę czterech kart
            //o dowolnej wartości przekazanej w postaci parametru.
            //Jeżleli w zestsawie znajduje się grupa, zwraca true, jeżeli nie to false
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.Value == value)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;

        }
    }
}
