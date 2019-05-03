using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Ace";
        }
        public string Suit { get; set; } /*You're setting up a property for this class, Card. This property is a Suit
        (hearts, spades, diamonds, clubs)*/
        public string Face { get; set; }
    }
}