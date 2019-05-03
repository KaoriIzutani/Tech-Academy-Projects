using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck = Shuffle(deck); /*Right here, is where you call the "Shuffle" method.*/
            //deck.Cards = new List<Card>(); /*You created a var named deck, with a property called Cards (created in your
            //Deck class), data type List<card>.*/


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle (Deck deck) /*Here, we're creating a method to shuffle the deck.*/
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0) /*The purpose is to grab a random card, take it out of the ordered deck
                and put it into a temporary deck (what the list called TempList represents). Do this while loop
                until the Cards count reaches 0.*/
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck; /*You're not done here. You now have to call the method for the shuffle to work.*/
        }
    }
}
