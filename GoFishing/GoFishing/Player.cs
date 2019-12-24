﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFishing
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            //Konstruktor klsy Player, inicjalizuje prywatne pola i dodaje
            //do kontrolki TextBox wiersz, który ma postać: "Janek dołączył do gry" - użyj jednak
            //prywatnego pola name i nie zapomnij dodać znakow nowej linina końcu każdego dodawanego wiersza
            this.name = name;
            this.random = random;

        }

        public IEnumerable<Values> PullOutBooks()
        {
            //Metoda przegląda w pętli wszystkie 13 wartości kart.Dla każdej z nich zlicza liczbę kart
            //o danej wartości dostępnych w polu cards obiektu gracza. Jeśli gracz posiada wszystkie
            //cztery karty o danej wartości dostępnych 
            List<Values> books = new List<Values>();
            for(int i = 1; i <= 23; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value)
                        howMany++;
                if(howMany == 4)
                {
                    books.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card--)
                        cards.Deal(card);
                }
            }
            return books;
        }

        public Values GetRandomValue()
        {
            //Ta metoda pobiera losową wartość, ale musi się ona najdować w zestawie
        }

        public Deck DoYouHaveAny(Values value)
        {
            //Tutaj przeciwnik sprawdza, czy masz karty o określonej wartości.
            //Wartości wyciągnięte za pomocą mietody Deck.PullOutValues(). Dodaj do kontrolki
            //TextBox napis "Janek ma 3 szustki" - użyj nowej statycznej metody Card.Plural()
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            //Tu jest przeciążona wersja AskForACard() - wybierz z zestawu losową wartość,
            //przy użyciu GetRandomValue() i zażądaj jej za pomocą AskForACard()
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            //Zażądaj określonej wartości od innych graczy. Na początku dodaj do pola tekstowego wiersz
            //w postaci "Janek pyta, czy ktoś ma damę". Następnie przejdź przez listę graczy przekazanych
            //do metody w postaci parametrów i spytaj każdego z nich, czy ma daną wartośc, przy użyciu 
            //metody DoYouHaveAny(). Przekaże ona zestaw kart - dodaje je do bieżącego zestawu.
            //Sprawdź ile kart zostało dodnych.Jeżeli nie było żadnej, to pociągnij 
            //jedną kartę z kupki( ona także została przekazana w postaci parametru). Na końcu
            //należy dodać do kontroli TextBox wiersz o postaci: "Janek pobrał kartę z kupki".
        }

        public int CardCound { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardsNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}
