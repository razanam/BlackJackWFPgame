using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Classes
{
    class Hand
    {
        /*
         * Rawnaz Anam Blackjack Project
         * Due date 11/11/2019
         * This class holds the cards that are in player's hand and dealer's hand.
         * 2 hand instances for both player and delar created in table.
         */
        private ArrayList cardsInHand;
        private int handValue; //sum of card values: 2-9 = face value, JQK = 10, A = 1 or 11
        private int numOfAces; //used to know when we can change ace value from 11 to 1

        public Hand()
        {
            this.cardsInHand = new ArrayList(2);
            this.handValue = 0;
            this.numOfAces = 0;
        }

        //update hand value each time a card is added
        //handle aces accordingly
        public void addCard(Card card)
        {
            if (card.getValue() == 1) //this is an Ace
            {
                this.handValue += 11;
                this.numOfAces++;
            }
            else if (card.getValue() > 10)
            {
                this.handValue += 10;
            }
            else
            {
                this.handValue += card.getValue();
            }
            this.cardsInHand.Add(card);
            this.checkHandValue();
        }

        //used to check if our handValue goes over 21 when we are in possession of aces
        //if this is the case, we will flip our aces' values from 11 to 1 as needed
        public void checkHandValue()
        {
            if (this.numOfAces == 0 || this.handValue <= 21)
            {
                return;
            }

            for (int i = 0; i < this.numOfAces; i++)
            {
                this.handValue -= 10;
                this.numOfAces--;
                if (this.handValue < 21)
                {
                    break;
                }
            }
        }

        //used to return the first card dealt to dealer in order to flip and get the appropriate image
        public Card flipDealerCard()
        {
            return (Card)this.cardsInHand[0];
            
        }

       

        //used to put cards back in deck
        public void resetHand()
        {
            this.numOfAces = 0;
            this.handValue = 0;

            this.cardsInHand.Clear();
        }

        //returns the current value of hand
        public int getHandValue()
        {
            return this.handValue;
        }

        //used by dealer when deciding move
        public bool hasAce()
        {
            return numOfAces > 0;
        }

        //return reference to the cardsInHand array so dealer can put cards back in deck
        public ArrayList getCards()
        {
          return  this.cardsInHand;
        }
    }
}
