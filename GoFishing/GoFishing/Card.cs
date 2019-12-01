using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFishing
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name
        {
            get
            {
                return Suit.ToString() + " of " + Value.ToString();
            }
        }


        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}
