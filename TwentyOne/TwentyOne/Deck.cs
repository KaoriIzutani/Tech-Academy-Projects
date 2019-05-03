using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>(); /*This refers back to the property "Cards" we created below. As a result, you don't 
            need to create a var or specify a data type, because it already has those things.*/
            List<string> Suits = new List<string>() { "Hearts", "Diamonds", "Clubs", "Spades" };
            List<string> Faces = new List<string> ()
                { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            foreach (string face in Faces) /*This foreach loop goes around 4 times. Because 13 x 4 = 52 cards in a deck.*/
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); /*Creating a new var, called card. The var was called on after it went through 
                    the foreach loop and assigned it a suit and a face.*/
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

            //Cards = new List<Card>(); /*This isn't the most efficient way to create the constructor. For this example,
            //you'd have to repeat this 51 times.*/
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
            //Console.ReadLine();
        }
        
        public List<Card> Cards { get; set; } /*Here, you're setting a property of the class Deck.*/
    }
}
