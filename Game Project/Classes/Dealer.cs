using Game_Project.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Project.Classes
{
    /*
     * Rawnaz Anam Blackjack Project
     * Due date 11/11/2019
     * Dealer class 
     * Shuffles the deck and deals the card into the table
     * After round is done pick up cards from the table
     */
    class Dealer
    {
        Deck theDeck;
        public Dealer()
        {
            theDeck = new Deck();
        }

        //takes a card from deck to distribute to either self or player's hand
        public Card dealCard()
        {
            return this.theDeck.removeCard();
        }

        //return cards to deck to get ready for next round
        public void pickUpCards(ArrayList tableCards)
        {
            foreach (Card card in tableCards)
            {
                this.theDeck.insertCard(card);
            }
        }

        //calls shuffle in deck class
        public void ShuffleDeck()
        {
            this.theDeck.shuffle();
        }

        //strategize what the best move would be based on values of both hands
        //true -> hit
        //false -> stand
        //Dealer strats: https://blog.udemy.com/blackjack-rules-2/
        public bool decideMove(int dealerHandValue, int playerHandValue, bool hasAce)
        {

            if (playerHandValue>21 || dealerHandValue >= playerHandValue || (dealerHandValue > 16 && !hasAce))
            {
                return false;
            }
            else if (dealerHandValue <= 16 || hasAce)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
