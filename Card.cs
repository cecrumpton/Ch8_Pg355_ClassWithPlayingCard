using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_Pg355_ClassWithPlayingCard
{
    class Card
    {
        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }

        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }
    }
}
