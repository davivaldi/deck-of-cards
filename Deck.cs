using System;
using System.Collections.Generic;

namespace deckofCards
{ 
    public class Deck{
        private int size = 52;
        public List<Card> Cards = new List<Card>();

        public Deck(){
            foreach (string suit in suits)
            {
                int numVal = 1;

                foreach (var stringVal in stringCards)
                {
                    Card newCard = new Card(stringVal, suit, numVal);
                    Cards.Add(newCard);
                    numVal++;
                }
            }
        }
        public Card deal(){
            Card dealt = Cards[0];
            Cards.RemoveAt(0);
            return dealt;
        }
        public void reset(){
            Cards.Clear();
            foreach (string suit in suits)
            {
                int numVal = 1;

                foreach (var stringVal in stringCards)
                {
                    Card newCard = new Card(stringVal, suit, numVal);
                    Cards.Add(newCard);
                    numVal++;
                }
            }
        }

        public int shuffle(){
        Random rand = new Random ();
            for (int i = 0; i < Cards.Count; i++)
            {
                int newIndx = rand.Next(Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[newIndx];
                Cards[newIndx] = temp;
            }
        }
    }
}