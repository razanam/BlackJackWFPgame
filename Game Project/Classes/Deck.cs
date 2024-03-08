using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Classes
{

    /*
     * Rawnaz Anam Blackjack Project
     * Due date 11/11/2019  
     * Holds all 52 card objects to make a deck.
     * Creates the card object to make a whole deck
     */
    class Deck
    {
        private ArrayList cards;
        private const int maxSize = 52; //should be a multiple of 52: determines # of decks used
        private const int shuffleSwaps = 1000;

        //generate a new deck with the amount of cards in maxSize
        public Deck()
        {
            char[] suits = { 'S', 'C', 'D', 'H' };
            cards = new ArrayList(Deck.maxSize);

            for (int i = 0; i < maxSize; i++)
            {
                //13 cards per suit
                int value = (i % 13) + 1;
                char suit = suits[(i / 13) % 4]; //mod 4: useful for multiple decks - 54 / 13 is OOR

                this.cards.Add(new Card(value, suit));
            }
        }

        //put a card into the end of the deck
        public void insertCard(Card card)
        {
            this.cards.Add(card);
        }

        //remove card from top of deck
        //use to deal cards
        public Card removeCard()
        {
            Card topCard = (Card)this.cards[0];
            this.cards.RemoveAt(0);
            return topCard;
        }

        //randomize card positions in array
        public void shuffle()
        {
            Random randomGenerator = new Random(); //instance of Random class: used to get random #s
            Card temp; //holds value of our card for swap

            //perform swaps between first index and random index
            //amount of swaps determined by class attribute shuffleSwaps
            for (int i = 0; i < Deck.shuffleSwaps; i++)
            {
                int randomIndex = randomGenerator.Next(this.cards.Count); //random # (0, deckSize - 1)
                temp = (Card)this.cards[randomIndex]; //get a card from middle of deck
                this.cards[randomIndex] = this.cards[0]; //put the top card in its place
                this.cards[0] = temp; //put the random card on top of the deck
            }
        }

        //return a string of Card.toString()'s
        //used when testing
        public String toString()
        {
            StringBuilder retStr = new StringBuilder();
            for (int i = 0; i < this.cards.Count; i++)
            {
                retStr.AppendLine(((Card)this.cards[i]).toString());
            }
            return retStr.ToString();
        }

        //array size - used to make sure we aren't losing cards - for testing
        public int getLength()
        {
            return this.cards.Count;
        }

    }
}

