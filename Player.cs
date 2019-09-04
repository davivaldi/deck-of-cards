using System;
using System.Collections.Generic;

namespace deckofCards
{
    public class Player
    {
        public string Name;
        public List<Card> hand = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public Card Draw(Deck deck, Player player)
        {
            string Player = player.Name;
            Card newCard = deck.Deal();
            System.Console.WriteLine($"{Player} drew {newCard.StringVal} of {newCard.Suit}");
            hand.Add(newCard);
            return newCard;
        }

        public Card Discard(int card)
        {
            if (hand[card] != null)
            {
                Card discard = hand[card];
                hand.Remove(discard);
                return discard;
            }
            return null;

        }
    }

}